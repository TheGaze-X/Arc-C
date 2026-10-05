using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006348 RID: 25416
	[Token(Token = "0x2006348")]
	public class AutoChessShopCharChessBondView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005695 RID: 22165
		// (get) Token: 0x06024AB5 RID: 150197 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06024AB6 RID: 150198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005695")]
		public ILoadAsset loader
		{
			[Token(Token = "0x6024AB5")]
			[Address(RVA = "0x1F81070", Offset = "0x1F7FC70", VA = "0x181F81070")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6024AB6")]
			[Address(RVA = "0x1F810D0", Offset = "0x1F7FCD0", VA = "0x181F810D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06024AB7 RID: 150199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024AB7")]
		[Address(RVA = "0x1F80EF0", Offset = "0x1F7FAF0", VA = "0x181F80EF0")]
		public void Render(AutoChessShopCharChessBondModel model)
		{
		}

		// Token: 0x06024AB8 RID: 150200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024AB8")]
		[Address(RVA = "0x1F81010", Offset = "0x1F7FC10", VA = "0x181F81010")]
		public AutoChessShopCharChessBondView()
		{
		}

		// Token: 0x040332AA RID: 209578
		[Token(Token = "0x40332AA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _bondImage;

		// Token: 0x040332AB RID: 209579
		[Token(Token = "0x40332AB")]
		[FieldOffset(Offset = "0x20")]
		private string m_cachedId;

		// Token: 0x040332AD RID: 209581
		[Token(Token = "0x40332AD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_loader;

		// Token: 0x040332AE RID: 209582
		[Token(Token = "0x40332AE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_loader;

		// Token: 0x040332AF RID: 209583
		[Token(Token = "0x40332AF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040332B0 RID: 209584
		[Token(Token = "0x40332B0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
