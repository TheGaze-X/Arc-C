using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006C52 RID: 27730
	[Token(Token = "0x2006C52")]
	public class ArchiveTrapController : ActArchiveController
	{
		// Token: 0x17005D88 RID: 23944
		// (get) Token: 0x06027950 RID: 162128 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06027951 RID: 162129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005D88")]
		public Action<ActArchiveType, string> onTrapItemClicked
		{
			[Token(Token = "0x6027950")]
			[Address(RVA = "0x22C59A0", Offset = "0x22C45A0", VA = "0x1822C59A0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6027951")]
			[Address(RVA = "0x22C5A00", Offset = "0x22C4600", VA = "0x1822C5A00")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06027952 RID: 162130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027952")]
		[Address(RVA = "0x22C56A0", Offset = "0x22C42A0", VA = "0x1822C56A0", Slot = "9")]
		public override void OnItemClick(string funcId)
		{
		}

		// Token: 0x06027953 RID: 162131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027953")]
		[Address(RVA = "0x22C53A0", Offset = "0x22C3FA0", VA = "0x1822C53A0")]
		public List<DataBinder<TrapProperty>> InitAndAchieveDataBinders()
		{
			return null;
		}

		// Token: 0x06027954 RID: 162132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027954")]
		[Address(RVA = "0x22C54D0", Offset = "0x22C40D0", VA = "0x1822C54D0", Slot = "4")]
		public override void Init(ActArchiveProxy proxy)
		{
		}

		// Token: 0x06027955 RID: 162133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027955")]
		[Address(RVA = "0x22C57C0", Offset = "0x22C43C0", VA = "0x1822C57C0", Slot = "7")]
		public override IEnumerator Show(bool fastMode)
		{
			return null;
		}

		// Token: 0x06027956 RID: 162134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027956")]
		[Address(RVA = "0x22C5940", Offset = "0x22C4540", VA = "0x1822C5940")]
		public ArchiveTrapController()
		{
		}

		// Token: 0x06027959 RID: 162137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027959")]
		[Address(RVA = "0x2263DC0", Offset = "0x22629C0", VA = "0x182263DC0")]
		private void <>xLuaBaseProxy_OnItemClick(string P0)
		{
		}

		// Token: 0x0602795A RID: 162138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602795A")]
		[Address(RVA = "0x2252DF0", Offset = "0x22519F0", VA = "0x182252DF0")]
		private void <>xLuaBaseProxy_Init(ActArchiveProxy P0)
		{
		}

		// Token: 0x0602795B RID: 162139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602795B")]
		[Address(RVA = "0x227CC90", Offset = "0x227B890", VA = "0x18227CC90")]
		private IEnumerator <>xLuaBaseProxy_Show(bool P0)
		{
			return null;
		}

		// Token: 0x04038225 RID: 229925
		[Token(Token = "0x4038225")]
		private const int START_PADDING_TOP = 200;

		// Token: 0x04038226 RID: 229926
		[Token(Token = "0x4038226")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ArchiveTrapListDataBinder _trapDataBinder;

		// Token: 0x04038227 RID: 229927
		[Token(Token = "0x4038227")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _imgBkg;

		// Token: 0x04038228 RID: 229928
		[Token(Token = "0x4038228")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GridLayoutGroup _layout;

		// Token: 0x04038229 RID: 229929
		[Token(Token = "0x4038229")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _imgTitleText;

		// Token: 0x0403822B RID: 229931
		[Token(Token = "0x403822B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onTrapItemClicked;

		// Token: 0x0403822C RID: 229932
		[Token(Token = "0x403822C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onTrapItemClicked;

		// Token: 0x0403822D RID: 229933
		[Token(Token = "0x403822D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnItemClick;

		// Token: 0x0403822E RID: 229934
		[Token(Token = "0x403822E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_InitAndAchieveDataBinders;

		// Token: 0x0403822F RID: 229935
		[Token(Token = "0x403822F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04038230 RID: 229936
		[Token(Token = "0x4038230")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x04038231 RID: 229937
		[Token(Token = "0x4038231")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
