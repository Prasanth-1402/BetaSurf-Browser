using System;

public class BookmarkDTO
{
    public String Title { get; set; }
    public String URL { get; set; }
    public BookmarkDTO()
	{
	}
	public BookmarkDTO(String title, String URL)
	{
		this.Title = title;
		this.URL = URL;
	}
}
