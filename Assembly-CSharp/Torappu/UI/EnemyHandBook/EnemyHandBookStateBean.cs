using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.EnemyHandBook
{
	// Token: 0x02004F49 RID: 20297
	[Token(Token = "0x2004F49")]
	public class EnemyHandBookStateBean : MonoBehaviour, IStateBean, IHotfixable, IDataBindWrapper
	{
		// Token: 0x170046DF RID: 18143
		// (get) Token: 0x0601E38C RID: 123788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170046DF")]
		public EnemyHandBookShowProperty property
		{
			[Token(Token = "0x601E38C")]
			[Address(RVA = "0x17ED6F0", Offset = "0x17EC2F0", VA = "0x1817ED6F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601E38D RID: 123789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E38D")]
		[Address(RVA = "0x17ECFA0", Offset = "0x17EBBA0", VA = "0x1817ECFA0")]
		public void SetBossShuffle(EnemyLevelMask type)
		{
		}

		// Token: 0x0601E38E RID: 123790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E38E")]
		[Address(RVA = "0x17ED490", Offset = "0x17EC090", VA = "0x1817ED490")]
		public void SetRaceShuffle(int index)
		{
		}

		// Token: 0x0601E38F RID: 123791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E38F")]
		[Address(RVA = "0x17ED320", Offset = "0x17EBF20", VA = "0x1817ED320")]
		public void SetMotionType(int index)
		{
		}

		// Token: 0x0601E390 RID: 123792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E390")]
		[Address(RVA = "0x17ECE30", Offset = "0x17EBA30", VA = "0x1817ECE30")]
		public void SetAttackType(int index)
		{
		}

		// Token: 0x0601E391 RID: 123793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E391")]
		[Address(RVA = "0x17ED0B0", Offset = "0x17EBCB0", VA = "0x1817ED0B0")]
		public void SetDamageType(int index)
		{
		}

		// Token: 0x0601E392 RID: 123794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E392")]
		[Address(RVA = "0x17ED220", Offset = "0x17EBE20", VA = "0x1817ED220")]
		public void SetIncreaseType()
		{
		}

		// Token: 0x0601E393 RID: 123795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E393")]
		[Address(RVA = "0x17EC5F0", Offset = "0x17EB1F0", VA = "0x1817EC5F0")]
		public void CleanSelect()
		{
		}

		// Token: 0x0601E394 RID: 123796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E394")]
		[Address(RVA = "0x17EC6A0", Offset = "0x17EB2A0", VA = "0x1817EC6A0")]
		public void InitIndexAndShowState()
		{
		}

		// Token: 0x0601E395 RID: 123797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E395")]
		[Address(RVA = "0x17ECDB0", Offset = "0x17EB9B0", VA = "0x1817ECDB0")]
		public void SelectFirstNewIdx()
		{
		}

		// Token: 0x0601E396 RID: 123798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E396")]
		[Address(RVA = "0x17EC870", Offset = "0x17EB470", VA = "0x1817EC870")]
		public void LoadDataFromStageId(string stageId)
		{
		}

		// Token: 0x0601E397 RID: 123799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E397")]
		[Address(RVA = "0x17ED600", Offset = "0x17EC200", VA = "0x1817ED600")]
		public EnemyHandBookStateBean()
		{
		}

		// Token: 0x040284A0 RID: 165024
		[Token(Token = "0x40284A0")]
		[FieldOffset(Offset = "0x18")]
		private EnemyHandBookShowProperty m_property;

		// Token: 0x040284A1 RID: 165025
		[Token(Token = "0x40284A1")]
		[FieldOffset(Offset = "0x20")]
		public int overrideSelectIdx;

		// Token: 0x040284A2 RID: 165026
		[Token(Token = "0x40284A2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_property;

		// Token: 0x040284A3 RID: 165027
		[Token(Token = "0x40284A3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetBossShuffle;

		// Token: 0x040284A4 RID: 165028
		[Token(Token = "0x40284A4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetRaceShuffle;

		// Token: 0x040284A5 RID: 165029
		[Token(Token = "0x40284A5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetMotionType;

		// Token: 0x040284A6 RID: 165030
		[Token(Token = "0x40284A6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetAttackType;

		// Token: 0x040284A7 RID: 165031
		[Token(Token = "0x40284A7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SetDamageType;

		// Token: 0x040284A8 RID: 165032
		[Token(Token = "0x40284A8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SetIncreaseType;

		// Token: 0x040284A9 RID: 165033
		[Token(Token = "0x40284A9")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CleanSelect;

		// Token: 0x040284AA RID: 165034
		[Token(Token = "0x40284AA")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_InitIndexAndShowState;

		// Token: 0x040284AB RID: 165035
		[Token(Token = "0x40284AB")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_SelectFirstNewIdx;

		// Token: 0x040284AC RID: 165036
		[Token(Token = "0x40284AC")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_LoadDataFromStageId;

		// Token: 0x040284AD RID: 165037
		[Token(Token = "0x40284AD")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
