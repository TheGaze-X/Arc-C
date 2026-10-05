using System;
using DG.Tweening.Core;
using Il2CppDummyDll;

namespace DG.Tweening.Plugins.Core
{
	// Token: 0x02000095 RID: 149
	[Token(Token = "0x2000095")]
	public interface IPlugSetter<T1, out T2, TPlugin, out TPlugOptions>
	{
		// Token: 0x06000379 RID: 889
		[Token(Token = "0x6000379")]
		DOGetter<T1> Getter();

		// Token: 0x0600037A RID: 890
		[Token(Token = "0x600037A")]
		DOSetter<T1> Setter();

		// Token: 0x0600037B RID: 891
		[Token(Token = "0x600037B")]
		T2 EndValue();

		// Token: 0x0600037C RID: 892
		[Token(Token = "0x600037C")]
		TPlugOptions GetOptions();
	}
}
