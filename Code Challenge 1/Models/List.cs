namespace Code_Challenge_1.Models
{
	public class List
	{
		public string? RequestId { get; set; }
        public string Task1 {get;set;}

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
        public bool ShowTask1 => !string.IsNullOrEmpty(Task1);
}
}