using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Crisis
{
	// Token: 0x02005A0C RID: 23052
	[Token(Token = "0x2005A0C")]
	public class CrisisSeasonShopView : MonoBehaviour
	{
		// Token: 0x06021962 RID: 137570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021962")]
		[Address(RVA = "0x1C04660", Offset = "0x1C03260", VA = "0x181C04660")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06021963 RID: 137571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021963")]
		[Address(RVA = "0x1C04510", Offset = "0x1C03110", VA = "0x181C04510")]
		public void RenderData(List<CrisisSeasonShopWrapped> data)
		{
		}

		// Token: 0x06021964 RID: 137572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021964")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public CrisisSeasonShopView()
		{
		}

		// Token: 0x0402DE60 RID: 188000
		[Token(Token = "0x402DE60")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _viewContainer;

		// Token: 0x0402DE61 RID: 188001
		[Token(Token = "0x402DE61")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public CrisisShopEvent clickEvent;

		// Token: 0x0402DE62 RID: 188002
		[Token(Token = "0x402DE62")]
		[FieldOffset(Offset = "0x28")]
		private CrisisSeasonShopView.Adapter m_adapter;

		// Token: 0x0402DE63 RID: 188003
		[Token(Token = "0x402DE63")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isInited;

		// Token: 0x02005A0D RID: 23053
		[Token(Token = "0x2005A0D")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x17004EE6 RID: 20198
			// (get) Token: 0x06021965 RID: 137573 RVA: 0x000BAD68 File Offset: 0x000B8F68
			[Token(Token = "0x17004EE6")]
			public override int count
			{
				[Token(Token = "0x6021965")]
				[Address(RVA = "0x1C023A0", Offset = "0x1C00FA0", VA = "0x181C023A0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06021966 RID: 137574 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6021966")]
			[Address(RVA = "0x1C01E70", Offset = "0x1C00A70", VA = "0x181C01E70", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06021967 RID: 137575 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021967")]
			[Address(RVA = "0x1C02230", Offset = "0x1C00E30", VA = "0x181C02230")]
			public Adapter()
			{
			}

			// Token: 0x0402DE64 RID: 188004
			[Token(Token = "0x402DE64")]
			[FieldOffset(Offset = "0x20")]
			public List<CrisisSeasonShopWrapped> viewModelList;

			// Token: 0x0402DE65 RID: 188005
			[Token(Token = "0x402DE65")]
			[FieldOffset(Offset = "0x28")]
			public CrisisShopEvent clickEvent;

			// Token: 0x0402DE66 RID: 188006
			[Token(Token = "0x402DE66")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402DE67 RID: 188007
			[Token(Token = "0x402DE67")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0402DE68 RID: 188008
			[Token(Token = "0x402DE68")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
