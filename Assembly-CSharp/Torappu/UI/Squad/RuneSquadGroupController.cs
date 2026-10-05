using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.Squad
{
	// Token: 0x02003E08 RID: 15880
	[Token(Token = "0x2003E08")]
	public class RuneSquadGroupController : DataBinder<SquadGroupViewProperty>
	{
		// Token: 0x17003AE3 RID: 15075
		// (get) Token: 0x06018B57 RID: 101207 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06018B58 RID: 101208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003AE3")]
		public Action<int> onSlotClicked
		{
			[Token(Token = "0x6018B57")]
			[Address(RVA = "0x1136800", Offset = "0x1135400", VA = "0x181136800")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6018B58")]
			[Address(RVA = "0x1136860", Offset = "0x1135460", VA = "0x181136860")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06018B59 RID: 101209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B59")]
		[Address(RVA = "0x1136540", Offset = "0x1135140", VA = "0x181136540")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06018B5A RID: 101210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B5A")]
		[Address(RVA = "0x1136310", Offset = "0x1134F10", VA = "0x181136310", Slot = "7")]
		public override void OnValueChanged(SquadGroupViewProperty property)
		{
		}

		// Token: 0x06018B5B RID: 101211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B5B")]
		[Address(RVA = "0x1136680", Offset = "0x1135280", VA = "0x181136680")]
		private void _OnCharCardClicked(RuneSquadCardView.Options options)
		{
		}

		// Token: 0x06018B5C RID: 101212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B5C")]
		[Address(RVA = "0x1136790", Offset = "0x1135390", VA = "0x181136790")]
		public RuneSquadGroupController()
		{
		}

		// Token: 0x0401E4D1 RID: 124113
		[Token(Token = "0x401E4D1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _squadLayout;

		// Token: 0x0401E4D2 RID: 124114
		[Token(Token = "0x401E4D2")]
		[FieldOffset(Offset = "0x28")]
		private RuneSquadGroupController.SquadAdapter m_squadAdapter;

		// Token: 0x0401E4D3 RID: 124115
		[Token(Token = "0x401E4D3")]
		[FieldOffset(Offset = "0x30")]
		private SquadViewModel m_squadModel;

		// Token: 0x0401E4D4 RID: 124116
		[Token(Token = "0x401E4D4")]
		[FieldOffset(Offset = "0x38")]
		private SquadGroupViewModel m_squadGroupModel;

		// Token: 0x0401E4D5 RID: 124117
		[Token(Token = "0x401E4D5")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isInited;

		// Token: 0x0401E4D6 RID: 124118
		[Token(Token = "0x401E4D6")]
		[FieldOffset(Offset = "0x48")]
		private SpriteHub m_professionHub;

		// Token: 0x0401E4D8 RID: 124120
		[Token(Token = "0x401E4D8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onSlotClicked;

		// Token: 0x0401E4D9 RID: 124121
		[Token(Token = "0x401E4D9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onSlotClicked;

		// Token: 0x0401E4DA RID: 124122
		[Token(Token = "0x401E4DA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401E4DB RID: 124123
		[Token(Token = "0x401E4DB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401E4DC RID: 124124
		[Token(Token = "0x401E4DC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnCharCardClicked;

		// Token: 0x0401E4DD RID: 124125
		[Token(Token = "0x401E4DD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003E09 RID: 15881
		[Token(Token = "0x2003E09")]
		private class SquadAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06018B5D RID: 101213 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018B5D")]
			[Address(RVA = "0x11370D0", Offset = "0x1135CD0", VA = "0x1811370D0")]
			public SquadAdapter(RuneSquadGroupController closure)
			{
			}

			// Token: 0x17003AE4 RID: 15076
			// (get) Token: 0x06018B5E RID: 101214 RVA: 0x0009B7C0 File Offset: 0x000999C0
			[Token(Token = "0x17003AE4")]
			public override int count
			{
				[Token(Token = "0x6018B5E")]
				[Address(RVA = "0x1137150", Offset = "0x1135D50", VA = "0x181137150", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06018B5F RID: 101215 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6018B5F")]
			[Address(RVA = "0x1136C10", Offset = "0x1135810", VA = "0x181136C10", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0401E4DE RID: 124126
			[Token(Token = "0x401E4DE")]
			[FieldOffset(Offset = "0x20")]
			private RuneSquadGroupController m_closure;

			// Token: 0x0401E4DF RID: 124127
			[Token(Token = "0x401E4DF")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401E4E0 RID: 124128
			[Token(Token = "0x401E4E0")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0401E4E1 RID: 124129
			[Token(Token = "0x401E4E1")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
