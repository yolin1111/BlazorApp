public class TodoItem
{
    public string? Title {get; set ;} //使用 ?，將 Title 宣告為可為 Null 字串。
    public bool IsDone {get; set;} = false;

}