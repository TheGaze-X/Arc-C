using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003C68 RID: 15464
	[Token(Token = "0x2003C68")]
	public class TuningChatSimpleComp : TuningChatFadeCompBase
	{
		// Token: 0x0601828D RID: 98957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601828D")]
		[Address(RVA = "0x10ABC00", Offset = "0x10AA800", VA = "0x1810ABC00")]
		public TuningChatSimpleComp()
		{
		}

		// Token: 0x0401D600 RID: 120320
		[Token(Token = "0x401D600")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _preferedHeight;

		// Token: 0x0401D601 RID: 120321
		[Token(Token = "0x401D601")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003C69 RID: 15465
		[Token(Token = "0x2003C69")]
		public class VirtualView : TuningChatFadeCompBase.VirtualViewBase<TuningChatSimpleComp>
		{
			// Token: 0x0601828E RID: 98958 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601828E")]
			[Address(RVA = "0x10BA930", Offset = "0x10B9530", VA = "0x1810BA930")]
			public VirtualView(TuningChatSimpleComp prefab)
			{
			}

			// Token: 0x0601828F RID: 98959 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601828F")]
			[Address(RVA = "0x10BA3A0", Offset = "0x10B8FA0", VA = "0x1810BA3A0", Slot = "22")]
			protected override void OnUpdateView(TuningChatSimpleComp view)
			{
			}

			// Token: 0x06018290 RID: 98960 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6018290")]
			[Address(RVA = "0x10BA0B0", Offset = "0x10B8CB0", VA = "0x1810BA0B0", Slot = "26")]
			protected override TuningChatSimpleComp FadePrefab()
			{
				return null;
			}

			// Token: 0x06018291 RID: 98961 RVA: 0x00099978 File Offset: 0x00097B78
			[Token(Token = "0x6018291")]
			[Address(RVA = "0x10BA2A0", Offset = "0x10B8EA0", VA = "0x1810BA2A0", Slot = "27")]
			protected override float GetPreferedHeight()
			{
				return 0f;
			}

			// Token: 0x0401D602 RID: 120322
			[Token(Token = "0x401D602")]
			[FieldOffset(Offset = "0x38")]
			private TuningChatSimpleComp m_prefab;

			// Token: 0x0401D603 RID: 120323
			[Token(Token = "0x401D603")]
			[FieldOffset(Offset = "0x40")]
			private float m_cachedSize;

			// Token: 0x0401D604 RID: 120324
			[Token(Token = "0x401D604")]
			[FieldOffset(Offset = "0x48")]
			private string m_dialogContent;

			// Token: 0x0401D605 RID: 120325
			[Token(Token = "0x401D605")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401D606 RID: 120326
			[Token(Token = "0x401D606")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnUpdateView;

			// Token: 0x0401D607 RID: 120327
			[Token(Token = "0x401D607")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_FadePrefab;

			// Token: 0x0401D608 RID: 120328
			[Token(Token = "0x401D608")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetPreferedHeight;
		}
	}
}
