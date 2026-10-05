using System;
using System.Xml;
using Il2CppDummyDll;

namespace System.Configuration
{
	// Token: 0x020003E3 RID: 995
	[Token(Token = "0x20003E3")]
	public interface IConfigurationSectionHandler
	{
		// Token: 0x06001A89 RID: 6793
		[Token(Token = "0x6001A89")]
		object Create(object parent, object configContext, XmlNode section);
	}
}
