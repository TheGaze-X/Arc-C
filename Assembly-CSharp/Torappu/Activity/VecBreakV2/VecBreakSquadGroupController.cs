using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using Torappu.UI.Squad;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E78 RID: 28280
	[Token(Token = "0x2006E78")]
	public class VecBreakSquadGroupController : DataBinder<SquadGroupViewProperty>
	{
		// Token: 0x060283DB RID: 164827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60283DB")]
		[Address(RVA = "0x2399800", Offset = "0x2398400", VA = "0x182399800", Slot = "7")]
		public override void OnValueChanged(SquadGroupViewProperty property)
		{
		}

		// Token: 0x060283DC RID: 164828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60283DC")]
		[Address(RVA = "0x2399BE0", Offset = "0x23987E0", VA = "0x182399BE0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060283DD RID: 164829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60283DD")]
		[Address(RVA = "0x2399E80", Offset = "0x2398A80", VA = "0x182399E80")]
		private void _RefreshStartBtnBg()
		{
		}

		// Token: 0x060283DE RID: 164830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60283DE")]
		[Address(RVA = "0x2399D20", Offset = "0x2398920", VA = "0x182399D20")]
		private void _OnCharCardClicked(SquadCardViewWithPredefine.Options options)
		{
		}

		// Token: 0x060283DF RID: 164831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60283DF")]
		[Address(RVA = "0x23995F0", Offset = "0x23981F0", VA = "0x1823995F0")]
		public void EventOnMultiFormationClicked()
		{
		}

		// Token: 0x060283E0 RID: 164832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60283E0")]
		[Address(RVA = "0x23994B0", Offset = "0x23980B0", VA = "0x1823994B0")]
		public void EventOnAssistBtnClick()
		{
		}

		// Token: 0x060283E1 RID: 164833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60283E1")]
		[Address(RVA = "0x2399550", Offset = "0x2398150", VA = "0x182399550")]
		public void EventOnAssistClearClick()
		{
		}

		// Token: 0x060283E2 RID: 164834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60283E2")]
		[Address(RVA = "0x2399750", Offset = "0x2398350", VA = "0x182399750")]
		public void EventOnStartBtnClick()
		{
		}

		// Token: 0x060283E3 RID: 164835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60283E3")]
		[Address(RVA = "0x2399FF0", Offset = "0x2398BF0", VA = "0x182399FF0")]
		public VecBreakSquadGroupController()
		{
		}

		// Token: 0x04039321 RID: 234273
		[Token(Token = "0x4039321")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _squadLayout;

		// Token: 0x04039322 RID: 234274
		[Token(Token = "0x4039322")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _startBattleImg;

		// Token: 0x04039323 RID: 234275
		[Token(Token = "0x4039323")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isInited;

		// Token: 0x04039324 RID: 234276
		[Token(Token = "0x4039324")]
		[FieldOffset(Offset = "0x38")]
		private VecBreakSquadGroupViewModel m_squadGroupModel;

		// Token: 0x04039325 RID: 234277
		[Token(Token = "0x4039325")]
		[FieldOffset(Offset = "0x40")]
		private SquadViewModel m_squadModel;

		// Token: 0x04039326 RID: 234278
		[Token(Token = "0x4039326")]
		[FieldOffset(Offset = "0x48")]
		private string m_teamId;

		// Token: 0x04039327 RID: 234279
		[Token(Token = "0x4039327")]
		[FieldOffset(Offset = "0x50")]
		private SpriteHub m_professionHub;

		// Token: 0x04039328 RID: 234280
		[Token(Token = "0x4039328")]
		[FieldOffset(Offset = "0x58")]
		private VecBreakSquadGroupController.SquadAdapter m_squadAdapter;

		// Token: 0x04039329 RID: 234281
		[Token(Token = "0x4039329")]
		[FieldOffset(Offset = "0x60")]
		private UIStateFinder m_finder;

		// Token: 0x0403932A RID: 234282
		[Token(Token = "0x403932A")]
		[FieldOffset(Offset = "0x70")]
		private SquadStartButtonTypeEnum m_startBtnType;

		// Token: 0x0403932B RID: 234283
		[Token(Token = "0x403932B")]
		[FieldOffset(Offset = "0x74")]
		private bool m_isStartBtnRefreshed;

		// Token: 0x0403932C RID: 234284
		[Token(Token = "0x403932C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403932D RID: 234285
		[Token(Token = "0x403932D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403932E RID: 234286
		[Token(Token = "0x403932E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RefreshStartBtnBg;

		// Token: 0x0403932F RID: 234287
		[Token(Token = "0x403932F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnCharCardClicked;

		// Token: 0x04039330 RID: 234288
		[Token(Token = "0x4039330")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnMultiFormationClicked;

		// Token: 0x04039331 RID: 234289
		[Token(Token = "0x4039331")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnAssistBtnClick;

		// Token: 0x04039332 RID: 234290
		[Token(Token = "0x4039332")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnAssistClearClick;

		// Token: 0x04039333 RID: 234291
		[Token(Token = "0x4039333")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnStartBtnClick;

		// Token: 0x04039334 RID: 234292
		[Token(Token = "0x4039334")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006E79 RID: 28281
		[Token(Token = "0x2006E79")]
		private class SquadAdapter : SimpleLayoutAdapter
		{
			// Token: 0x060283E4 RID: 164836 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60283E4")]
			[Address(RVA = "0x23968C0", Offset = "0x23954C0", VA = "0x1823968C0")]
			public SquadAdapter(VecBreakSquadGroupController controller)
			{
			}

			// Token: 0x17005F0A RID: 24330
			// (get) Token: 0x060283E5 RID: 164837 RVA: 0x000D0FB0 File Offset: 0x000CF1B0
			[Token(Token = "0x17005F0A")]
			public override int count
			{
				[Token(Token = "0x60283E5")]
				[Address(RVA = "0x2396940", Offset = "0x2395540", VA = "0x182396940", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060283E6 RID: 164838 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60283E6")]
			[Address(RVA = "0x23965C0", Offset = "0x23951C0", VA = "0x1823965C0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04039335 RID: 234293
			[Token(Token = "0x4039335")]
			[FieldOffset(Offset = "0x20")]
			private VecBreakSquadGroupController m_closure;

			// Token: 0x04039336 RID: 234294
			[Token(Token = "0x4039336")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04039337 RID: 234295
			[Token(Token = "0x4039337")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04039338 RID: 234296
			[Token(Token = "0x4039338")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
