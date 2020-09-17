
namespace Common.DTO
{
    public class LastProjectAndTaskInfoDTO
    {
        public UserDTO Author { get; set; }
        public ProjectDTO LastProject { get; set; }
        public int TaskCount { get; set; }
        public int UnfinishedOrCanceledTaskCount { get; set; }
        public TaskDTO LongestTask { get; set; }
    }
}
