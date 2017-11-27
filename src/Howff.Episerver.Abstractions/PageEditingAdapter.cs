using System.Web;

using EPiServer.Core;
using EPiServer.Editor;

namespace Howff.Episerver.Abstractions {
	public class PageEditingAdapter : IPageEditing {
		public bool PageIsInEditMode => PageEditing.PageIsInEditMode;

		public string GetEditUrl(ContentReference contentLink) {
			return PageEditing.GetEditUrl(contentLink);
		}

		public string GetEditUrlForLanguage(ContentReference contentLink, string language) {
			return PageEditing.GetEditUrlForLanguage(contentLink, language);
		}

		public string GetChannel(HttpContextBase httpContext) {
			return PageEditing.GetChannel(httpContext);
		}
	}
}