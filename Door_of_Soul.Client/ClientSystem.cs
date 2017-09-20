using Door_of_Soul.Communication.Client.System;
using Door_of_Soul.Core.Client;
using Door_of_Soul.Core.Protocol;
using System;

namespace Door_of_Soul.Client
{
    public class ClientSystem : VirtualSystem
    {
        public event Action<ClientAnswer> OnProxyAnswerLoaded;

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

        public override void LoadProxyAnswer(int answerId, string answerName, int[] soulIds)
        {
            ClientAnswer answer;
            if(AnswerFactory.Instance.Create(answerId, answerName, soulIds, out answer))
            {
                VirtualAnswer.Initialize(answer);
                OnProxyAnswerLoaded?.Invoke(answer);
            }
        }
    }
}
