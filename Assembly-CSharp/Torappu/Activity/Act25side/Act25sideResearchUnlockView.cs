using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act25side
{
	// Token: 0x0200751C RID: 29980
	[Token(Token = "0x200751C")]
	public class Act25sideResearchUnlockView : DataBinder<Act25sideResearchUnlockProperty>
	{
		// Token: 0x0602A3FB RID: 173051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3FB")]
		[Address(RVA = "0x25EA440", Offset = "0x25E9040", VA = "0x1825EA440", Slot = "7")]
		public override void OnValueChanged(Act25sideResearchUnlockProperty property)
		{
		}

		// Token: 0x0602A3FC RID: 173052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3FC")]
		[Address(RVA = "0x25EA550", Offset = "0x25E9150", VA = "0x1825EA550")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602A3FD RID: 173053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3FD")]
		[Address(RVA = "0x25EA780", Offset = "0x25E9380", VA = "0x1825EA780")]
		public Act25sideResearchUnlockView()
		{
		}

		// Token: 0x0403CBB9 RID: 248761
		[Token(Token = "0x403CBB9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _descContent;

		// Token: 0x0403CBBA RID: 248762
		[Token(Token = "0x403CBBA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _picContent;

		// Token: 0x0403CBBB RID: 248763
		[Token(Token = "0x403CBBB")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isInited;

		// Token: 0x0403CBBC RID: 248764
		[Token(Token = "0x403CBBC")]
		[FieldOffset(Offset = "0x38")]
		private Act25sideResearchUnlockView.DescAdapter m_descAdapter;

		// Token: 0x0403CBBD RID: 248765
		[Token(Token = "0x403CBBD")]
		[FieldOffset(Offset = "0x40")]
		private Act25sideResearchUnlockView.PicAdapter m_picAdapter;

		// Token: 0x0403CBBE RID: 248766
		[Token(Token = "0x403CBBE")]
		[FieldOffset(Offset = "0x48")]
		private Act25sideResearchUnlockViewModel m_cachedViewModel;

		// Token: 0x0403CBBF RID: 248767
		[Token(Token = "0x403CBBF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403CBC0 RID: 248768
		[Token(Token = "0x403CBC0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403CBC1 RID: 248769
		[Token(Token = "0x403CBC1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200751D RID: 29981
		[Token(Token = "0x200751D")]
		private class DescAdapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x0602A3FE RID: 173054 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A3FE")]
			[Address(RVA = "0x25ECE70", Offset = "0x25EBA70", VA = "0x1825ECE70")]
			public DescAdapter(Act25sideResearchUnlockView closure)
			{
			}

			// Token: 0x17006367 RID: 25447
			// (get) Token: 0x0602A3FF RID: 173055 RVA: 0x000D7BF8 File Offset: 0x000D5DF8
			[Token(Token = "0x17006367")]
			public override int count
			{
				[Token(Token = "0x602A3FF")]
				[Address(RVA = "0x25ECEF0", Offset = "0x25EBAF0", VA = "0x1825ECEF0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602A400 RID: 173056 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602A400")]
			[Address(RVA = "0x25ECC90", Offset = "0x25EB890", VA = "0x1825ECC90", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403CBC2 RID: 248770
			[Token(Token = "0x403CBC2")]
			[FieldOffset(Offset = "0x20")]
			private Act25sideResearchUnlockView m_closure;

			// Token: 0x0403CBC3 RID: 248771
			[Token(Token = "0x403CBC3")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403CBC4 RID: 248772
			[Token(Token = "0x403CBC4")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403CBC5 RID: 248773
			[Token(Token = "0x403CBC5")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x0200751E RID: 29982
		[Token(Token = "0x200751E")]
		private class PicAdapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x0602A401 RID: 173057 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A401")]
			[Address(RVA = "0x25ED300", Offset = "0x25EBF00", VA = "0x1825ED300")]
			public PicAdapter(Act25sideResearchUnlockView closure)
			{
			}

			// Token: 0x17006368 RID: 25448
			// (get) Token: 0x0602A402 RID: 173058 RVA: 0x000D7C10 File Offset: 0x000D5E10
			[Token(Token = "0x17006368")]
			public override int count
			{
				[Token(Token = "0x602A402")]
				[Address(RVA = "0x25ED380", Offset = "0x25EBF80", VA = "0x1825ED380", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602A403 RID: 173059 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602A403")]
			[Address(RVA = "0x25ECFB0", Offset = "0x25EBBB0", VA = "0x1825ECFB0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403CBC6 RID: 248774
			[Token(Token = "0x403CBC6")]
			[FieldOffset(Offset = "0x20")]
			private Act25sideResearchUnlockView m_closure;

			// Token: 0x0403CBC7 RID: 248775
			[Token(Token = "0x403CBC7")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403CBC8 RID: 248776
			[Token(Token = "0x403CBC8")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403CBC9 RID: 248777
			[Token(Token = "0x403CBC9")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
