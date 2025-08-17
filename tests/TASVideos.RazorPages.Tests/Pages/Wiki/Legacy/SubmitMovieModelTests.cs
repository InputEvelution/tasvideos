﻿using TASVideos.Pages.Wiki.Legacy;

namespace TASVideos.RazorPages.Tests.Pages.Wiki.Legacy;

[TestClass]
public class SubmitMovieModelTests : BasePageModelTests
{
	private readonly SubmitMovieModel _model = new()
	{
		PageContext = TestPageContext()
	};

	[TestMethod]
	public void OnGet_ReturnsRedirectToPermissionsIndex()
	{
		var result = _model.OnGet();

		Assert.IsInstanceOfType(result, typeof(RedirectToPageResult));
		var redirectResult = (RedirectToPageResult)result;
		Assert.AreEqual("/Submissions/Submit", redirectResult.PageName);
	}
}
