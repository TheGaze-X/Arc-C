using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020035E6 RID: 13798
	[Token(Token = "0x20035E6")]
	public abstract class CommonSquadLayoutViewBase : DataBinder<CommonSquadGroupViewProperty>
	{
		// Token: 0x170034CE RID: 13518
		// (get) Token: 0x06015F95 RID: 90005 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06015F96 RID: 90006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170034CE")]
		private protected CommonCharCardView commonCharCardRes
		{
			[Token(Token = "0x6015F95")]
			[Address(RVA = "0xE777A0", Offset = "0xE763A0", VA = "0x180E777A0")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6015F96")]
			[Address(RVA = "0xE77860", Offset = "0xE76460", VA = "0x180E77860")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170034CF RID: 13519
		// (get) Token: 0x06015F97 RID: 90007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170034CF")]
		protected SimpleLayoutContent squadLayout
		{
			[Token(Token = "0x6015F97")]
			[Address(RVA = "0xE77800", Offset = "0xE76400", VA = "0x180E77800")]
			get
			{
				return null;
			}
		}

		// Token: 0x06015F98 RID: 90008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015F98")]
		[Address(RVA = "0xE77490", Offset = "0xE76090", VA = "0x180E77490")]
		private void _InitIfNot(CommonSquadGroupViewModel groupViewModel)
		{
		}

		// Token: 0x06015F99 RID: 90009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015F99")]
		[Address(RVA = "0xE77430", Offset = "0xE76030", VA = "0x180E77430", Slot = "8")]
		public virtual void RegisterTutorialGO()
		{
		}

		// Token: 0x06015F9A RID: 90010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015F9A")]
		[Address(RVA = "0xE77160", Offset = "0xE75D60", VA = "0x180E77160", Slot = "9")]
		protected virtual void OnCharCardClicked(CommonSquadCardViewBase.Options options)
		{
		}

		// Token: 0x06015F9B RID: 90011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015F9B")]
		[Address(RVA = "0xE772B0", Offset = "0xE75EB0", VA = "0x180E772B0", Slot = "10")]
		protected virtual void OnStateValueChanged(CommonSquadGroupViewModel commonSquadGroupViewModel)
		{
		}

		// Token: 0x06015F9C RID: 90012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015F9C")]
		[Address(RVA = "0xE77030", Offset = "0xE75C30", VA = "0x180E77030")]
		public void BindCard(CommonCharCardView cardRes)
		{
		}

		// Token: 0x06015F9D RID: 90013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015F9D")]
		[Address(RVA = "0xE77310", Offset = "0xE75F10", VA = "0x180E77310", Slot = "7")]
		public sealed override void OnValueChanged(CommonSquadGroupViewProperty property)
		{
		}

		// Token: 0x06015F9E RID: 90014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015F9E")]
		[Address(RVA = "0xE77730", Offset = "0xE76330", VA = "0x180E77730")]
		protected CommonSquadLayoutViewBase()
		{
		}

		// Token: 0x0401A673 RID: 108147
		[Token(Token = "0x401A673")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _squadLayoutContent;

		// Token: 0x0401A674 RID: 108148
		[Token(Token = "0x401A674")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isInited;

		// Token: 0x0401A675 RID: 108149
		[Token(Token = "0x401A675")]
		[FieldOffset(Offset = "0x30")]
		private CommonSquadLayoutViewBase.CommonSquadAdapter m_squadAdapter;

		// Token: 0x0401A677 RID: 108151
		[Token(Token = "0x401A677")]
		[FieldOffset(Offset = "0x40")]
		protected UIStateFinder stateFinder;

		// Token: 0x0401A678 RID: 108152
		[Token(Token = "0x401A678")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_commonCharCardRes;

		// Token: 0x0401A679 RID: 108153
		[Token(Token = "0x401A679")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_commonCharCardRes;

		// Token: 0x0401A67A RID: 108154
		[Token(Token = "0x401A67A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_squadLayout;

		// Token: 0x0401A67B RID: 108155
		[Token(Token = "0x401A67B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401A67C RID: 108156
		[Token(Token = "0x401A67C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RegisterTutorialGO;

		// Token: 0x0401A67D RID: 108157
		[Token(Token = "0x401A67D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnCharCardClicked;

		// Token: 0x0401A67E RID: 108158
		[Token(Token = "0x401A67E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnStateValueChanged;

		// Token: 0x0401A67F RID: 108159
		[Token(Token = "0x401A67F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_BindCard;

		// Token: 0x0401A680 RID: 108160
		[Token(Token = "0x401A680")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401A681 RID: 108161
		[Token(Token = "0x401A681")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020035E7 RID: 13799
		[Token(Token = "0x20035E7")]
		public class CommonSquadAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06015F9F RID: 90015 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015F9F")]
			[Address(RVA = "0xE74EF0", Offset = "0xE73AF0", VA = "0x180E74EF0")]
			public CommonSquadAdapter(CommonSquadLayoutViewBase.CommonSquadAdapter.Input input)
			{
			}

			// Token: 0x170034D0 RID: 13520
			// (get) Token: 0x06015FA0 RID: 90016 RVA: 0x0008EF08 File Offset: 0x0008D108
			[Token(Token = "0x170034D0")]
			public override int count
			{
				[Token(Token = "0x6015FA0")]
				[Address(RVA = "0xE74FD0", Offset = "0xE73BD0", VA = "0x180E74FD0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06015FA1 RID: 90017 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6015FA1")]
			[Address(RVA = "0xE74C50", Offset = "0xE73850", VA = "0x180E74C50", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0401A682 RID: 108162
			[Token(Token = "0x401A682")]
			[FieldOffset(Offset = "0x20")]
			[NonSerialized]
			public Action<CommonSquadCardViewBase.Options> onClick;

			// Token: 0x0401A683 RID: 108163
			[Token(Token = "0x401A683")]
			[FieldOffset(Offset = "0x28")]
			private CommonSquadGroupViewModel m_groupViewModel;

			// Token: 0x0401A684 RID: 108164
			[Token(Token = "0x401A684")]
			[FieldOffset(Offset = "0x30")]
			private SpriteHub m_professionHub;

			// Token: 0x0401A685 RID: 108165
			[Token(Token = "0x401A685")]
			[FieldOffset(Offset = "0x38")]
			private CommonCharCardView m_cardRes;

			// Token: 0x0401A686 RID: 108166
			[Token(Token = "0x401A686")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401A687 RID: 108167
			[Token(Token = "0x401A687")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0401A688 RID: 108168
			[Token(Token = "0x401A688")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x020035E8 RID: 13800
			[Token(Token = "0x20035E8")]
			public struct Input
			{
				// Token: 0x0401A689 RID: 108169
				[Token(Token = "0x401A689")]
				[FieldOffset(Offset = "0x0")]
				public CommonCharCardView cardRes;

				// Token: 0x0401A68A RID: 108170
				[Token(Token = "0x401A68A")]
				[FieldOffset(Offset = "0x8")]
				public CommonSquadGroupViewModel groupViewModel;

				// Token: 0x0401A68B RID: 108171
				[Token(Token = "0x401A68B")]
				[FieldOffset(Offset = "0x10")]
				public SpriteHub professionHub;
			}
		}
	}
}
