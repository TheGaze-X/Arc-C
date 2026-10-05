using System;
using System.ComponentModel.Design.Serialization;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x0200020A RID: 522
	[Token(Token = "0x200020A")]
	[TypeConverter(typeof(ComponentConverter))]
	[RootDesignerSerializer("System.ComponentModel.Design.Serialization.RootCodeDomSerializer, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.ComponentModel.Design.Serialization.CodeDomSerializer, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", true)]
	[ComVisible(true)]
	public interface IComponent : IDisposable
	{
		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06000DC0 RID: 3520
		// (set) Token: 0x06000DC1 RID: 3521
		[Token(Token = "0x170002E2")]
		ISite Site { [Token(Token = "0x6000DC0")] get; [Token(Token = "0x6000DC1")] set; }

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x06000DC2 RID: 3522
		// (remove) Token: 0x06000DC3 RID: 3523
		[Token(Token = "0x1400000E")]
		event EventHandler Disposed;
	}
}
