using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Recruit.GachaPlugins
{
	// Token: 0x02004771 RID: 18289
	[Token(Token = "0x2004771")]
	public class RecruitGachaAttainRare6 : RecruitGachaItemPlugin, IPlayerDataListener, IHotfixable
	{
		// Token: 0x0601BB0F RID: 113423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BB0F")]
		[Address(RVA = "0x1515560", Offset = "0x1514160", VA = "0x181515560", Slot = "4")]
		protected override void OnRefreshData(RecruitGachaItemViewBase host)
		{
		}

		// Token: 0x0601BB10 RID: 113424 RVA: 0x000A5D98 File Offset: 0x000A3F98
		[Token(Token = "0x601BB10")]
		[Address(RVA = "0x15152B0", Offset = "0x1513EB0", VA = "0x1815152B0", Slot = "5")]
		public bool CheckIfDataChanged(PlayerDataModel prevData, PlayerDataModel curData, PlayerDataDelta delta)
		{
			return default(bool);
		}

		// Token: 0x0601BB11 RID: 113425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BB11")]
		[Address(RVA = "0x1515410", Offset = "0x1514010", VA = "0x181515410", Slot = "6")]
		public void OnPlayerDataChanged()
		{
		}

		// Token: 0x0601BB12 RID: 113426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BB12")]
		[Address(RVA = "0x1515820", Offset = "0x1514420", VA = "0x181515820")]
		private void _Render()
		{
		}

		// Token: 0x0601BB13 RID: 113427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BB13")]
		[Address(RVA = "0x15156F0", Offset = "0x15142F0", VA = "0x1815156F0")]
		private void _InitIfNot(string gachaPoolId)
		{
		}

		// Token: 0x0601BB14 RID: 113428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BB14")]
		[Address(RVA = "0x15153B0", Offset = "0x1513FB0", VA = "0x1815153B0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0601BB15 RID: 113429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BB15")]
		[Address(RVA = "0x1515940", Offset = "0x1514540", VA = "0x181515940")]
		public RecruitGachaAttainRare6()
		{
		}

		// Token: 0x04023FB4 RID: 147380
		[Token(Token = "0x4023FB4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelSecure6;

		// Token: 0x04023FB5 RID: 147381
		[Token(Token = "0x4023FB5")]
		[FieldOffset(Offset = "0x20")]
		private RecruitGachaAttainRare6.PlayerParam m_playerParam;

		// Token: 0x04023FB6 RID: 147382
		[Token(Token = "0x4023FB6")]
		[FieldOffset(Offset = "0x28")]
		private string m_cachedPoolId;

		// Token: 0x04023FB7 RID: 147383
		[Token(Token = "0x4023FB7")]
		[FieldOffset(Offset = "0x30")]
		private bool m_hasInited;

		// Token: 0x04023FB8 RID: 147384
		[Token(Token = "0x4023FB8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRefreshData;

		// Token: 0x04023FB9 RID: 147385
		[Token(Token = "0x4023FB9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CheckIfDataChanged;

		// Token: 0x04023FBA RID: 147386
		[Token(Token = "0x4023FBA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnPlayerDataChanged;

		// Token: 0x04023FBB RID: 147387
		[Token(Token = "0x4023FBB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x04023FBC RID: 147388
		[Token(Token = "0x4023FBC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04023FBD RID: 147389
		[Token(Token = "0x4023FBD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04023FBE RID: 147390
		[Token(Token = "0x4023FBE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004772 RID: 18290
		[Token(Token = "0x2004772")]
		private class PlayerParam : IHotfixable
		{
			// Token: 0x0601BB16 RID: 113430 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601BB16")]
			[Address(RVA = "0x1507950", Offset = "0x1506550", VA = "0x181507950")]
			public PlayerParam(RecruitGachaAttainRare6 closure)
			{
			}

			// Token: 0x0601BB17 RID: 113431 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601BB17")]
			[Address(RVA = "0x1506D30", Offset = "0x1505930", VA = "0x181506D30")]
			public void UpdateData()
			{
			}

			// Token: 0x0601BB18 RID: 113432 RVA: 0x000A5DB0 File Offset: 0x000A3FB0
			[Token(Token = "0x601BB18")]
			[Address(RVA = "0x1506B80", Offset = "0x1505780", VA = "0x181506B80")]
			public bool HasAttain6()
			{
				return default(bool);
			}

			// Token: 0x0601BB19 RID: 113433 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601BB19")]
			[Address(RVA = "0x15068E0", Offset = "0x15054E0", VA = "0x1815068E0")]
			public List<string> GetAttain6List()
			{
				return null;
			}

			// Token: 0x04023FBF RID: 147391
			[Token(Token = "0x4023FBF")]
			private const string ATTAIN_6_NUM = "attainRare6Num";

			// Token: 0x04023FC0 RID: 147392
			[Token(Token = "0x4023FC0")]
			private const string ATTAIN_6_CHAR = "attainRare6CharList";

			// Token: 0x04023FC1 RID: 147393
			[Token(Token = "0x4023FC1")]
			[FieldOffset(Offset = "0x10")]
			private JObjectWrapper m_dataParam;

			// Token: 0x04023FC2 RID: 147394
			[Token(Token = "0x4023FC2")]
			[FieldOffset(Offset = "0x18")]
			private PlayerGacha.PlayerAttainGacha m_playerAttainGacha;

			// Token: 0x04023FC3 RID: 147395
			[Token(Token = "0x4023FC3")]
			[FieldOffset(Offset = "0x20")]
			private List<string> m_attainRare6CharList;

			// Token: 0x04023FC4 RID: 147396
			[Token(Token = "0x4023FC4")]
			[FieldOffset(Offset = "0x28")]
			private RecruitGachaAttainRare6 m_closure;

			// Token: 0x04023FC5 RID: 147397
			[Token(Token = "0x4023FC5")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04023FC6 RID: 147398
			[Token(Token = "0x4023FC6")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_UpdateData;

			// Token: 0x04023FC7 RID: 147399
			[Token(Token = "0x4023FC7")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_HasAttain6;

			// Token: 0x04023FC8 RID: 147400
			[Token(Token = "0x4023FC8")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetAttain6List;
		}
	}
}
