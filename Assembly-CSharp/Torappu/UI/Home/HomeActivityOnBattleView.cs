using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004BF1 RID: 19441
	[Token(Token = "0x2004BF1")]
	public class HomeActivityOnBattleView : DataBinder<ActivityOnBattleViewProperty>
	{
		// Token: 0x170044B2 RID: 17586
		// (get) Token: 0x0601D359 RID: 119641 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601D35A RID: 119642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170044B2")]
		public Action<string> onJumpToActivityClicked
		{
			[Token(Token = "0x601D359")]
			[Address(RVA = "0x16BE1B0", Offset = "0x16BCDB0", VA = "0x1816BE1B0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601D35A")]
			[Address(RVA = "0x16BE390", Offset = "0x16BCF90", VA = "0x1816BE390")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170044B3 RID: 17587
		// (get) Token: 0x0601D35B RID: 119643 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601D35C RID: 119644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170044B3")]
		public Action<string> onJumpToCrisisV2Clicked
		{
			[Token(Token = "0x601D35B")]
			[Address(RVA = "0x16BE210", Offset = "0x16BCE10", VA = "0x1816BE210")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601D35C")]
			[Address(RVA = "0x16BE410", Offset = "0x16BD010", VA = "0x1816BE410")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170044B4 RID: 17588
		// (get) Token: 0x0601D35D RID: 119645 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601D35E RID: 119646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170044B4")]
		public Action<string> onJumpToRoguelikeClicked
		{
			[Token(Token = "0x601D35D")]
			[Address(RVA = "0x16BE2D0", Offset = "0x16BCED0", VA = "0x1816BE2D0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601D35E")]
			[Address(RVA = "0x16BE510", Offset = "0x16BD110", VA = "0x1816BE510")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170044B5 RID: 17589
		// (get) Token: 0x0601D35F RID: 119647 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601D360 RID: 119648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170044B5")]
		public Action<string> onJumpToMainlineClicked
		{
			[Token(Token = "0x601D35F")]
			[Address(RVA = "0x16BE270", Offset = "0x16BCE70", VA = "0x1816BE270")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601D360")]
			[Address(RVA = "0x16BE490", Offset = "0x16BD090", VA = "0x1816BE490")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170044B6 RID: 17590
		// (get) Token: 0x0601D361 RID: 119649 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601D362 RID: 119650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170044B6")]
		public Action<string> onJumpToSandboxPermClicked
		{
			[Token(Token = "0x601D361")]
			[Address(RVA = "0x16BE330", Offset = "0x16BCF30", VA = "0x1816BE330")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601D362")]
			[Address(RVA = "0x16BE590", Offset = "0x16BD190", VA = "0x1816BE590")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601D363 RID: 119651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D363")]
		[Address(RVA = "0x16BD8F0", Offset = "0x16BC4F0", VA = "0x1816BD8F0", Slot = "7")]
		public override void OnValueChanged(ActivityOnBattleViewProperty property)
		{
		}

		// Token: 0x0601D364 RID: 119652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D364")]
		[Address(RVA = "0x16BDAC0", Offset = "0x16BC6C0", VA = "0x1816BDAC0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601D365 RID: 119653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D365")]
		[Address(RVA = "0x16BDBE0", Offset = "0x16BC7E0", VA = "0x1816BDBE0")]
		private void _OnActivityClicked(string activityId)
		{
		}

		// Token: 0x0601D366 RID: 119654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D366")]
		[Address(RVA = "0x16BDCC0", Offset = "0x16BC8C0", VA = "0x1816BDCC0")]
		private void _OnCrisisSeasonClicked(string seasonId)
		{
		}

		// Token: 0x0601D367 RID: 119655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D367")]
		[Address(RVA = "0x16BDF70", Offset = "0x16BCB70", VA = "0x1816BDF70")]
		private void _OnRoguelikeClicked(string topicId)
		{
		}

		// Token: 0x0601D368 RID: 119656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D368")]
		[Address(RVA = "0x16BDDA0", Offset = "0x16BC9A0", VA = "0x1816BDDA0")]
		private void _OnCrisisV2Clicked(string topicId)
		{
		}

		// Token: 0x0601D369 RID: 119657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D369")]
		[Address(RVA = "0x16BDE80", Offset = "0x16BCA80", VA = "0x1816BDE80")]
		private void _OnMainlineClicked(string topicId)
		{
		}

		// Token: 0x0601D36A RID: 119658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D36A")]
		[Address(RVA = "0x16BE050", Offset = "0x16BCC50", VA = "0x1816BE050")]
		private void _OnSandboxPermClicked(string topicId)
		{
		}

		// Token: 0x0601D36B RID: 119659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D36B")]
		[Address(RVA = "0x16BE140", Offset = "0x16BCD40", VA = "0x1816BE140")]
		public HomeActivityOnBattleView()
		{
		}

		// Token: 0x040265D9 RID: 157145
		[Token(Token = "0x40265D9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x040265DA RID: 157146
		[Token(Token = "0x40265DA")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isInited;

		// Token: 0x040265DB RID: 157147
		[Token(Token = "0x40265DB")]
		[FieldOffset(Offset = "0x30")]
		private ActivityOnBattleViewModel m_viewModel;

		// Token: 0x040265DC RID: 157148
		[Token(Token = "0x40265DC")]
		[FieldOffset(Offset = "0x38")]
		private HomeActivityOnBattleView.Adapter m_contentAdapter;

		// Token: 0x040265E2 RID: 157154
		[Token(Token = "0x40265E2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onJumpToActivityClicked;

		// Token: 0x040265E3 RID: 157155
		[Token(Token = "0x40265E3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onJumpToActivityClicked;

		// Token: 0x040265E4 RID: 157156
		[Token(Token = "0x40265E4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onJumpToCrisisV2Clicked;

		// Token: 0x040265E5 RID: 157157
		[Token(Token = "0x40265E5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onJumpToCrisisV2Clicked;

		// Token: 0x040265E6 RID: 157158
		[Token(Token = "0x40265E6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_onJumpToRoguelikeClicked;

		// Token: 0x040265E7 RID: 157159
		[Token(Token = "0x40265E7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_onJumpToRoguelikeClicked;

		// Token: 0x040265E8 RID: 157160
		[Token(Token = "0x40265E8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_onJumpToMainlineClicked;

		// Token: 0x040265E9 RID: 157161
		[Token(Token = "0x40265E9")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_onJumpToMainlineClicked;

		// Token: 0x040265EA RID: 157162
		[Token(Token = "0x40265EA")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_onJumpToSandboxPermClicked;

		// Token: 0x040265EB RID: 157163
		[Token(Token = "0x40265EB")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_onJumpToSandboxPermClicked;

		// Token: 0x040265EC RID: 157164
		[Token(Token = "0x40265EC")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040265ED RID: 157165
		[Token(Token = "0x40265ED")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040265EE RID: 157166
		[Token(Token = "0x40265EE")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnActivityClicked;

		// Token: 0x040265EF RID: 157167
		[Token(Token = "0x40265EF")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnCrisisSeasonClicked;

		// Token: 0x040265F0 RID: 157168
		[Token(Token = "0x40265F0")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OnRoguelikeClicked;

		// Token: 0x040265F1 RID: 157169
		[Token(Token = "0x40265F1")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnCrisisV2Clicked;

		// Token: 0x040265F2 RID: 157170
		[Token(Token = "0x40265F2")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__OnMainlineClicked;

		// Token: 0x040265F3 RID: 157171
		[Token(Token = "0x40265F3")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__OnSandboxPermClicked;

		// Token: 0x040265F4 RID: 157172
		[Token(Token = "0x40265F4")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004BF2 RID: 19442
		[Token(Token = "0x2004BF2")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x0601D36C RID: 119660 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D36C")]
			[Address(RVA = "0x16B71A0", Offset = "0x16B5DA0", VA = "0x1816B71A0")]
			public Adapter(HomeActivityOnBattleView closure)
			{
			}

			// Token: 0x170044B7 RID: 17591
			// (get) Token: 0x0601D36D RID: 119661 RVA: 0x000AAE50 File Offset: 0x000A9050
			[Token(Token = "0x170044B7")]
			public override int count
			{
				[Token(Token = "0x601D36D")]
				[Address(RVA = "0x16B7620", Offset = "0x16B6220", VA = "0x1816B7620", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601D36E RID: 119662 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601D36E")]
			[Address(RVA = "0x16B6470", Offset = "0x16B5070", VA = "0x1816B6470", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x040265F5 RID: 157173
			[Token(Token = "0x40265F5")]
			[FieldOffset(Offset = "0x20")]
			private HomeActivityOnBattleView m_closure;

			// Token: 0x040265F6 RID: 157174
			[Token(Token = "0x40265F6")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040265F7 RID: 157175
			[Token(Token = "0x40265F7")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040265F8 RID: 157176
			[Token(Token = "0x40265F8")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
