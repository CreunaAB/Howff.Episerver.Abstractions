using System.Web;

using EPiServer.Core;

namespace Howff.Episerver.Abstractions {
	public interface IPageEditing {
		bool PageIsInEditMode { get; }

		string GetEditUrl(ContentReference contentLink);
		string GetEditUrlForLanguage(ContentReference contentLink, string language);
		string GetChannel(HttpContextBase httpContext);
	}
}