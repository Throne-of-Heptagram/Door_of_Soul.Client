using System;
using Door_of_Soul.Communication.Client.System;
using Door_of_Soul.Core.Client;
using Door_of_Soul.Core.Protocol;

namespace Door_of_Soul.Client
{
    public class ClientSystem : VirtualSystem
    {
        public override event Action<OperationReturnCode, string> OnRegisterResponse;
        public override event LoginResponseEventHandler OnLoginResponse;

        public override string ToString()
        {
            return $"Client{base.ToString()}";
        }

        public override OperationReturnCode Register(string answerName, string basicPassword, out string errorMessage)
        {
            if (answerName.Length < 1 || answerName.Length > 20)
            {
                errorMessage = $"AnswerName length should be 1~20, your submit length:{answerName.Length}";
                return OperationReturnCode.ParameterFormateError;
            }
            else
            {
                SystemOperationRequestApi.Register(answerName, basicPassword);
                errorMessage = "";
                return OperationReturnCode.Successiful;
            }
        }

        public override OperationReturnCode Login(string answerName, string basicPassword, out string errorMessage)
        {
            if (answerName.Length < 1 || answerName.Length > 20)
            {
                errorMessage = $"AnswerName length should be 1~20, your submit length:{answerName.Length}";
                return OperationReturnCode.ParameterFormateError;
            }
            else
            {
                SystemOperationRequestApi.Login(answerName, basicPassword);
                errorMessage = "";
                return OperationReturnCode.Successiful;
            }
        }

        public override void RegisterResponse(OperationReturnCode returnCode, string operationMessage)
        {
            OnRegisterResponse?.Invoke(returnCode, operationMessage);
        }

        public override void LoginResponse(OperationReturnCode returnCode, string operationMessage, string trinityServerAddress, int trinityServerPort, string trinityServerApplicationName, int answerId, string answerAccessToken)
        {
            OnLoginResponse?.Invoke(returnCode, operationMessage, trinityServerAddress, trinityServerPort, trinityServerApplicationName, answerId, answerAccessToken);
        }
    }
}
