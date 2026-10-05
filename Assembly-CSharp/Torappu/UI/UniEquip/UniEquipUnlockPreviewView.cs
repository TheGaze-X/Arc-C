using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.UniEquip
{
	// Token: 0x02003C50 RID: 15440
	[Token(Token = "0x2003C50")]
	public class UniEquipUnlockPreviewView : DataBinder<UnlockViewProperty>
	{
		// Token: 0x0601821B RID: 98843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601821B")]
		[Address(RVA = "0x109F2F0", Offset = "0x109DEF0", VA = "0x18109F2F0", Slot = "7")]
		public override void OnValueChanged(UnlockViewProperty property)
		{
		}

		// Token: 0x0601821C RID: 98844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601821C")]
		[Address(RVA = "0x109F6F0", Offset = "0x109E2F0", VA = "0x18109F6F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601821D RID: 98845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601821D")]
		[Address(RVA = "0x109F5E0", Offset = "0x109E1E0", VA = "0x18109F5E0")]
		private void _InitAnimIfNot()
		{
		}

		// Token: 0x0601821E RID: 98846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601821E")]
		[Address(RVA = "0x109F930", Offset = "0x109E530", VA = "0x18109F930")]
		private void _SetVisible(bool v)
		{
		}

		// Token: 0x0601821F RID: 98847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601821F")]
		[Address(RVA = "0x109F800", Offset = "0x109E400", VA = "0x18109F800")]
		private void _PlayAnim(bool isShow)
		{
		}

		// Token: 0x06018220 RID: 98848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018220")]
		[Address(RVA = "0x109F520", Offset = "0x109E120", VA = "0x18109F520")]
		private IEnumerator _InfoEffectAnim(bool isShow)
		{
			return null;
		}

		// Token: 0x06018221 RID: 98849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018221")]
		[Address(RVA = "0x109FC00", Offset = "0x109E800", VA = "0x18109FC00")]
		public UniEquipUnlockPreviewView()
		{
		}

		// Token: 0x0401D559 RID: 120153
		[Token(Token = "0x401D559")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIFadeFloatPanel _floatPanel;

		// Token: 0x0401D55A RID: 120154
		[Token(Token = "0x401D55A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x0401D55B RID: 120155
		[Token(Token = "0x401D55B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAnimationLocation _animLocation;

		// Token: 0x0401D55C RID: 120156
		[Token(Token = "0x401D55C")]
		[FieldOffset(Offset = "0x40")]
		private AnimationSwitchTween m_animSwitchTween;

		// Token: 0x0401D55D RID: 120157
		[Token(Token = "0x401D55D")]
		[FieldOffset(Offset = "0x48")]
		private UniEquipUnlockPreviewView.InfoAdapter m_infoAdapter;

		// Token: 0x0401D55E RID: 120158
		[Token(Token = "0x401D55E")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isInited;

		// Token: 0x0401D55F RID: 120159
		[Token(Token = "0x401D55F")]
		[FieldOffset(Offset = "0x51")]
		private bool m_isAnimInited;

		// Token: 0x0401D560 RID: 120160
		[Token(Token = "0x401D560")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401D561 RID: 120161
		[Token(Token = "0x401D561")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401D562 RID: 120162
		[Token(Token = "0x401D562")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitAnimIfNot;

		// Token: 0x0401D563 RID: 120163
		[Token(Token = "0x401D563")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SetVisible;

		// Token: 0x0401D564 RID: 120164
		[Token(Token = "0x401D564")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__PlayAnim;

		// Token: 0x0401D565 RID: 120165
		[Token(Token = "0x401D565")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InfoEffectAnim;

		// Token: 0x0401D566 RID: 120166
		[Token(Token = "0x401D566")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003C51 RID: 15441
		[Token(Token = "0x2003C51")]
		private class InfoAdapter : SimpleLayoutAdapter
		{
			// Token: 0x170039A6 RID: 14758
			// (get) Token: 0x06018222 RID: 98850 RVA: 0x000997B0 File Offset: 0x000979B0
			[Token(Token = "0x170039A6")]
			public override int count
			{
				[Token(Token = "0x6018222")]
				[Address(RVA = "0x108E580", Offset = "0x108D180", VA = "0x18108E580", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06018223 RID: 98851 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6018223")]
			[Address(RVA = "0x108E0B0", Offset = "0x108CCB0", VA = "0x18108E0B0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06018224 RID: 98852 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018224")]
			[Address(RVA = "0x108E470", Offset = "0x108D070", VA = "0x18108E470")]
			public InfoAdapter()
			{
			}

			// Token: 0x0401D567 RID: 120167
			[Token(Token = "0x401D567")]
			[FieldOffset(Offset = "0x20")]
			public UniEquipUnlockViewModel viewModel;

			// Token: 0x0401D568 RID: 120168
			[Token(Token = "0x401D568")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0401D569 RID: 120169
			[Token(Token = "0x401D569")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0401D56A RID: 120170
			[Token(Token = "0x401D56A")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
