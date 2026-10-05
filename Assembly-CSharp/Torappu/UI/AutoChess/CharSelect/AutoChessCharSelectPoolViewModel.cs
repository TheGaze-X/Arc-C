using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.TemplateCharSelect;
using Torappu.UI.TemplateCharSelect.Common;
using XLua;

namespace Torappu.UI.AutoChess.CharSelect
{
	// Token: 0x020063C6 RID: 25542
	[Token(Token = "0x20063C6")]
	public class AutoChessCharSelectPoolViewModel : CommonCharSelectPoolViewModel
	{
		// Token: 0x170056F5 RID: 22261
		// (get) Token: 0x06024D3A RID: 150842 RVA: 0x000C5910 File Offset: 0x000C3B10
		// (set) Token: 0x06024D3B RID: 150843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170056F5")]
		public int selectMaximum
		{
			[Token(Token = "0x6024D3A")]
			[Address(RVA = "0x1FBABD0", Offset = "0x1FB97D0", VA = "0x181FBABD0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6024D3B")]
			[Address(RVA = "0x1FBAC30", Offset = "0x1FB9830", VA = "0x181FBAC30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06024D3C RID: 150844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024D3C")]
		[Address(RVA = "0x1FB94D0", Offset = "0x1FB80D0", VA = "0x181FB94D0", Slot = "7")]
		public override void Reset(TemplateCharSelectModelResetData data)
		{
		}

		// Token: 0x06024D3D RID: 150845 RVA: 0x000C5928 File Offset: 0x000C3B28
		[Token(Token = "0x6024D3D")]
		[Address(RVA = "0x1FBA480", Offset = "0x1FB9080", VA = "0x181FBA480")]
		private int _AllocInstId()
		{
			return 0;
		}

		// Token: 0x06024D3E RID: 150846 RVA: 0x000C5940 File Offset: 0x000C3B40
		[Token(Token = "0x6024D3E")]
		[Address(RVA = "0x1FBA9C0", Offset = "0x1FB95C0", VA = "0x181FBA9C0")]
		private bool _ValidChar(PlayerCharacter playerChar)
		{
			return default(bool);
		}

		// Token: 0x06024D3F RID: 150847 RVA: 0x000C5958 File Offset: 0x000C3B58
		[Token(Token = "0x6024D3F")]
		[Address(RVA = "0x1FBA7C0", Offset = "0x1FB93C0", VA = "0x181FBA7C0")]
		private bool _UsedForChess(PlayerCharacter playerChar)
		{
			return default(bool);
		}

		// Token: 0x06024D40 RID: 150848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024D40")]
		[Address(RVA = "0x1FB9F60", Offset = "0x1FB8B60", VA = "0x181FB9F60")]
		private void _AddUnusedBackupChar(string actId, ActAutoChessData.ActAutoChessCharShopChessData forChess, HashSet<string> alreadyAdd)
		{
		}

		// Token: 0x06024D41 RID: 150849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024D41")]
		[Address(RVA = "0x1FBA4E0", Offset = "0x1FB90E0", VA = "0x181FBA4E0")]
		private AutoChessCharSelectCardViewModel _CreateBackupChar(string actId, int instId, ActAutoChessData.ActAutoChessCharShopChessData forChess, ActAutoChessData.ActAutoChessCharShopChessData originChess, ActAutoChessData.ActAutoChessCharShopChessData inChess)
		{
			return null;
		}

		// Token: 0x06024D42 RID: 150850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024D42")]
		[Address(RVA = "0x1FBAB70", Offset = "0x1FB9770", VA = "0x181FBAB70")]
		public AutoChessCharSelectPoolViewModel()
		{
		}

		// Token: 0x06024D43 RID: 150851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024D43")]
		[Address(RVA = "0x1FB9F30", Offset = "0x1FB8B30", VA = "0x181FB9F30")]
		private void <>xLuaBaseProxy_Reset(TemplateCharSelectModelResetData P0)
		{
		}

		// Token: 0x040337CC RID: 210892
		[Token(Token = "0x40337CC")]
		[FieldOffset(Offset = "0x68")]
		private AutoChessData m_systemData;

		// Token: 0x040337CD RID: 210893
		[Token(Token = "0x40337CD")]
		[FieldOffset(Offset = "0x70")]
		private ActAutoChessData m_actData;

		// Token: 0x040337CE RID: 210894
		[Token(Token = "0x40337CE")]
		[FieldOffset(Offset = "0x78")]
		private RarityRank m_rarityLimit;

		// Token: 0x040337CF RID: 210895
		[Token(Token = "0x40337CF")]
		[FieldOffset(Offset = "0x7C")]
		private int m_localInstIdNum;

		// Token: 0x040337D1 RID: 210897
		[Token(Token = "0x40337D1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_selectMaximum;

		// Token: 0x040337D2 RID: 210898
		[Token(Token = "0x40337D2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_selectMaximum;

		// Token: 0x040337D3 RID: 210899
		[Token(Token = "0x40337D3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x040337D4 RID: 210900
		[Token(Token = "0x40337D4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__AllocInstId;

		// Token: 0x040337D5 RID: 210901
		[Token(Token = "0x40337D5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ValidChar;

		// Token: 0x040337D6 RID: 210902
		[Token(Token = "0x40337D6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UsedForChess;

		// Token: 0x040337D7 RID: 210903
		[Token(Token = "0x40337D7")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__AddUnusedBackupChar;

		// Token: 0x040337D8 RID: 210904
		[Token(Token = "0x40337D8")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CreateBackupChar;

		// Token: 0x040337D9 RID: 210905
		[Token(Token = "0x40337D9")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
