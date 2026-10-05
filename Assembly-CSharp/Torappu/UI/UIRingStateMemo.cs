using System;
using Il2CppDummyDll;
using Torappu.Resource;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020036DD RID: 14045
	[Token(Token = "0x20036DD")]
	public class UIRingStateMemo : AssetInfoMemoInScene<UIRingStateMemo>
	{
		// Token: 0x06016505 RID: 91397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016505")]
		[Address(RVA = "0xED4870", Offset = "0xED3470", VA = "0x180ED4870")]
		public UIRingStateGraph LoadFromTimeline(string resPath)
		{
			return null;
		}

		// Token: 0x06016506 RID: 91398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016506")]
		[Address(RVA = "0xED4990", Offset = "0xED3590", VA = "0x180ED4990", Slot = "4")]
		protected override object ReadInfoFromAsset(string resPath, UnityEngine.Object asset)
		{
			return null;
		}

		// Token: 0x06016507 RID: 91399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016507")]
		[Address(RVA = "0xED4A90", Offset = "0xED3690", VA = "0x180ED4A90")]
		private UIRingStateMemo()
		{
		}

		// Token: 0x0401AD69 RID: 109929
		[Token(Token = "0x401AD69")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadFromTimeline;

		// Token: 0x0401AD6A RID: 109930
		[Token(Token = "0x401AD6A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ReadInfoFromAsset;

		// Token: 0x0401AD6B RID: 109931
		[Token(Token = "0x401AD6B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
