
using System;

namespace TestTraining.Tests.TestabilityQuiz
{
    // Challenge: Unit test when a support request
    // is already closed, an exception is expected
    public class SupportCommandHandler
    {
        private const int _closedStatus = 1;
        private readonly SqlConnection _sqlConnection;
        public SupportCommandHandler(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }

        void Handle(SupportCommand message)
        {
            var status = _sqlConnection.QuerySingleAsync<int>(
                "select status from support where id = @id",
                new { id = message.Id });
            if (status == _closedStatus)
            {
                throw new Exception("This issue is already closed");
            }

            // handle logic, insert to db...
        }
    }

    public class SupportCommand
    {
        public int Id { get; set; }
        public string Message { get; set; }
    }

    public class SqlConnection
    {
        public T QuerySingleAsync<T>(string query, dynamic parameters)
        {
            // DB query logic
            return default(T);
        }
    }
}
