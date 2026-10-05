using System;
using Il2CppDummyDll;
using Torappu.AsyncLoader;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x020065B5 RID: 26037
	[Token(Token = "0x20065B5")]
	public class ArtMagazineLeafElementAsyncLoader : PageSingleComponent, ITimeWatcher
	{
		// Token: 0x1700587D RID: 22653
		// (get) Token: 0x060256B3 RID: 153267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700587D")]
		public AsyncGameObjectLoader objLoader
		{
			[Token(Token = "0x60256B3")]
			[Address(RVA = "0x2066910", Offset = "0x2065510", VA = "0x182066910")]
			get
			{
				return null;
			}
		}

		// Token: 0x060256B4 RID: 153268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60256B4")]
		[Address(RVA = "0x20667D0", Offset = "0x20653D0", VA = "0x1820667D0")]
		private void OnEnable()
		{
		}

		// Token: 0x060256B5 RID: 153269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60256B5")]
		[Address(RVA = "0x2066770", Offset = "0x2065370", VA = "0x182066770")]
		private void OnDisable()
		{
		}

		// Token: 0x060256B6 RID: 153270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60256B6")]
		[Address(RVA = "0x2066830", Offset = "0x2065430", VA = "0x182066830", Slot = "12")]
		public void UpdateTime(float delta)
		{
		}

		// Token: 0x060256B7 RID: 153271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60256B7")]
		[Address(RVA = "0x20668B0", Offset = "0x20654B0", VA = "0x1820668B0")]
		public ArtMagazineLeafElementAsyncLoader()
		{
		}

		// Token: 0x0403483E RID: 215102
		[Token(Token = "0x403483E")]
		private const int LEAF_ELEMENT_PER_FRAME = 3;

		// Token: 0x0403483F RID: 215103
		[Token(Token = "0x403483F")]
		[FieldOffset(Offset = "0x20")]
		private AsyncGameObjectLoader m_objLoader;

		// Token: 0x04034840 RID: 215104
		[Token(Token = "0x4034840")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_objLoader;

		// Token: 0x04034841 RID: 215105
		[Token(Token = "0x4034841")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x04034842 RID: 215106
		[Token(Token = "0x4034842")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x04034843 RID: 215107
		[Token(Token = "0x4034843")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateTime;

		// Token: 0x04034844 RID: 215108
		[Token(Token = "0x4034844")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
