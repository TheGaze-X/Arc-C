using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006FB6 RID: 28598
	[Token(Token = "0x2006FB6")]
	public class ActMultiV3SquadClassColVirtualView : UIRecycleLayoutAdapter.VirtualView<ActMultiV3SquadColView>
	{
		// Token: 0x060289BE RID: 166334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60289BE")]
		[Address(RVA = "0x23EED80", Offset = "0x23ED980", VA = "0x1823EED80")]
		public ActMultiV3SquadClassColVirtualView(ActMultiV3SquadClassColVirtualView.Param param)
		{
		}

		// Token: 0x060289BF RID: 166335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60289BF")]
		[Address(RVA = "0x23EEA10", Offset = "0x23ED610", VA = "0x1823EEA10", Slot = "12")]
		public override GameObject GetPrefab()
		{
			return null;
		}

		// Token: 0x060289C0 RID: 166336 RVA: 0x000D2630 File Offset: 0x000D0830
		[Token(Token = "0x60289C0")]
		[Address(RVA = "0x23EEA70", Offset = "0x23ED670", VA = "0x1823EEA70", Slot = "13")]
		public override float GetPreferSize()
		{
			return 0f;
		}

		// Token: 0x060289C1 RID: 166337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60289C1")]
		[Address(RVA = "0x23EEAD0", Offset = "0x23ED6D0", VA = "0x1823EEAD0", Slot = "10")]
		protected override void OnViewAttached()
		{
		}

		// Token: 0x060289C2 RID: 166338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60289C2")]
		[Address(RVA = "0x23EED20", Offset = "0x23ED920", VA = "0x1823EED20", Slot = "11")]
		protected override void OnViewDetached()
		{
		}

		// Token: 0x04039D96 RID: 236950
		[Token(Token = "0x4039D96")]
		[FieldOffset(Offset = "0x20")]
		private GameObject m_viewPrefab;

		// Token: 0x04039D97 RID: 236951
		[Token(Token = "0x4039D97")]
		[FieldOffset(Offset = "0x28")]
		private float m_viewWidth;

		// Token: 0x04039D98 RID: 236952
		[Token(Token = "0x4039D98")]
		[FieldOffset(Offset = "0x30")]
		private List<ActMultiV3CharViewModel> m_charList;

		// Token: 0x04039D99 RID: 236953
		[Token(Token = "0x4039D99")]
		[FieldOffset(Offset = "0x38")]
		private ActMultiV3IdentityType m_identityType;

		// Token: 0x04039D9A RID: 236954
		[Token(Token = "0x4039D9A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04039D9B RID: 236955
		[Token(Token = "0x4039D9B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetPrefab;

		// Token: 0x04039D9C RID: 236956
		[Token(Token = "0x4039D9C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetPreferSize;

		// Token: 0x04039D9D RID: 236957
		[Token(Token = "0x4039D9D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnViewAttached;

		// Token: 0x04039D9E RID: 236958
		[Token(Token = "0x4039D9E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnViewDetached;

		// Token: 0x02006FB7 RID: 28599
		[Token(Token = "0x2006FB7")]
		public class Param
		{
			// Token: 0x060289C3 RID: 166339 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60289C3")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x04039D9F RID: 236959
			[Token(Token = "0x4039D9F")]
			[FieldOffset(Offset = "0x10")]
			public GameObject viewPrefab;

			// Token: 0x04039DA0 RID: 236960
			[Token(Token = "0x4039DA0")]
			[FieldOffset(Offset = "0x18")]
			public float viewWidth;

			// Token: 0x04039DA1 RID: 236961
			[Token(Token = "0x4039DA1")]
			[FieldOffset(Offset = "0x20")]
			public List<ActMultiV3CharViewModel> charList;

			// Token: 0x04039DA2 RID: 236962
			[Token(Token = "0x4039DA2")]
			[FieldOffset(Offset = "0x28")]
			public ActMultiV3IdentityType identityType;
		}
	}
}
