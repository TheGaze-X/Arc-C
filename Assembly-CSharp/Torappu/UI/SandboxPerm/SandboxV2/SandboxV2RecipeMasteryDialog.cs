using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200409F RID: 16543
	[Token(Token = "0x200409F")]
	public class SandboxV2RecipeMasteryDialog : UICompDialog<SandboxV2RecipeMasteryDialog.Options>
	{
		// Token: 0x0601998C RID: 104844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601998C")]
		[Address(RVA = "0x1257650", Offset = "0x1256250", VA = "0x181257650")]
		public void OnConfirmEvent()
		{
		}

		// Token: 0x0601998D RID: 104845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601998D")]
		[Address(RVA = "0x1257CB0", Offset = "0x12568B0", VA = "0x181257CB0")]
		public void PlayAudio()
		{
		}

		// Token: 0x0601998E RID: 104846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601998E")]
		[Address(RVA = "0x12575F0", Offset = "0x12561F0", VA = "0x1812575F0", Slot = "15")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0601998F RID: 104847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601998F")]
		[Address(RVA = "0x1257700", Offset = "0x1256300", VA = "0x181257700", Slot = "9")]
		protected override void OnInit()
		{
		}

		// Token: 0x06019990 RID: 104848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019990")]
		[Address(RVA = "0x1257870", Offset = "0x1256470", VA = "0x181257870", Slot = "18")]
		protected override void OnRender(SandboxV2RecipeMasteryDialog.Options input)
		{
		}

		// Token: 0x06019991 RID: 104849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019991")]
		[Address(RVA = "0x1257D40", Offset = "0x1256940", VA = "0x181257D40")]
		private void _ResetAnimation()
		{
		}

		// Token: 0x06019992 RID: 104850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019992")]
		[Address(RVA = "0x1257DC0", Offset = "0x12569C0", VA = "0x181257DC0")]
		public SandboxV2RecipeMasteryDialog()
		{
		}

		// Token: 0x06019993 RID: 104851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019993")]
		[Address(RVA = "0xE613B0", Offset = "0xE5FFB0", VA = "0x180E613B0")]
		private UIRenderTextureImage <>xLuaBaseProxy_GetBlurTarget()
		{
			return null;
		}

		// Token: 0x06019994 RID: 104852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019994")]
		[Address(RVA = "0xE613C0", Offset = "0xE5FFC0", VA = "0x180E613C0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0401FF77 RID: 130935
		[Token(Token = "0x401FF77")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIRenderTextureImage _blurBackground;

		// Token: 0x0401FF78 RID: 130936
		[Token(Token = "0x401FF78")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Image _foodIconImage;

		// Token: 0x0401FF79 RID: 130937
		[Token(Token = "0x401FF79")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _foodNameText;

		// Token: 0x0401FF7A RID: 130938
		[Token(Token = "0x401FF7A")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _foodUsageText;

		// Token: 0x0401FF7B RID: 130939
		[Token(Token = "0x401FF7B")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _foodDescText;

		// Token: 0x0401FF7C RID: 130940
		[Token(Token = "0x401FF7C")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject[] _successPanels;

		// Token: 0x0401FF7D RID: 130941
		[Token(Token = "0x401FF7D")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject[] _failedPanels;

		// Token: 0x0401FF7E RID: 130942
		[Token(Token = "0x401FF7E")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private SimpleLayoutContent _goodContent;

		// Token: 0x0401FF7F RID: 130943
		[Token(Token = "0x401FF7F")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private UIAnimationLocation _animationLocation;

		// Token: 0x0401FF80 RID: 130944
		[Token(Token = "0x401FF80")]
		[FieldOffset(Offset = "0xC0")]
		private SandboxV2RecipeMasteryDialog.Adapter m_adapter;

		// Token: 0x0401FF81 RID: 130945
		[Token(Token = "0x401FF81")]
		[FieldOffset(Offset = "0xC8")]
		private float m_clipLength;

		// Token: 0x0401FF82 RID: 130946
		[Token(Token = "0x401FF82")]
		[FieldOffset(Offset = "0xD0")]
		private UIItemViewModel m_cachedItem;

		// Token: 0x0401FF83 RID: 130947
		[Token(Token = "0x401FF83")]
		[FieldOffset(Offset = "0xD8")]
		private int m_goodCount;

		// Token: 0x0401FF84 RID: 130948
		[Token(Token = "0x401FF84")]
		[FieldOffset(Offset = "0xE0")]
		private UIAnimationTween m_animationTween;

		// Token: 0x0401FF85 RID: 130949
		[Token(Token = "0x401FF85")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnConfirmEvent;

		// Token: 0x0401FF86 RID: 130950
		[Token(Token = "0x401FF86")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_PlayAudio;

		// Token: 0x0401FF87 RID: 130951
		[Token(Token = "0x401FF87")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x0401FF88 RID: 130952
		[Token(Token = "0x401FF88")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0401FF89 RID: 130953
		[Token(Token = "0x401FF89")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0401FF8A RID: 130954
		[Token(Token = "0x401FF8A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ResetAnimation;

		// Token: 0x0401FF8B RID: 130955
		[Token(Token = "0x401FF8B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020040A0 RID: 16544
		[Token(Token = "0x20040A0")]
		public class Options
		{
			// Token: 0x06019995 RID: 104853 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019995")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Options()
			{
			}

			// Token: 0x0401FF8C RID: 130956
			[Token(Token = "0x401FF8C")]
			[FieldOffset(Offset = "0x10")]
			public UIItemViewModel item;

			// Token: 0x0401FF8D RID: 130957
			[Token(Token = "0x401FF8D")]
			[FieldOffset(Offset = "0x18")]
			public bool isFailed;
		}

		// Token: 0x020040A1 RID: 16545
		[Token(Token = "0x20040A1")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x17003D15 RID: 15637
			// (get) Token: 0x06019996 RID: 104854 RVA: 0x0009EC40 File Offset: 0x0009CE40
			[Token(Token = "0x17003D15")]
			public override int count
			{
				[Token(Token = "0x6019996")]
				[Address(RVA = "0x1242FE0", Offset = "0x1241BE0", VA = "0x181242FE0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06019997 RID: 104855 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019997")]
			[Address(RVA = "0x1242A20", Offset = "0x1241620", VA = "0x181242A20")]
			public Adapter(SandboxV2RecipeMasteryDialog closure)
			{
			}

			// Token: 0x06019998 RID: 104856 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6019998")]
			[Address(RVA = "0x1242210", Offset = "0x1240E10", VA = "0x181242210", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0401FF8E RID: 130958
			[Token(Token = "0x401FF8E")]
			[FieldOffset(Offset = "0x20")]
			private SandboxV2RecipeMasteryDialog m_closure;

			// Token: 0x0401FF8F RID: 130959
			[Token(Token = "0x401FF8F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0401FF90 RID: 130960
			[Token(Token = "0x401FF90")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401FF91 RID: 130961
			[Token(Token = "0x401FF91")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
