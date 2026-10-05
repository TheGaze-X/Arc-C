using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Recruit
{
	// Token: 0x02004757 RID: 18263
	[Token(Token = "0x2004757")]
	public class RecruitGachaCostAddition : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601BA70 RID: 113264 RVA: 0x000A5BD0 File Offset: 0x000A3DD0
		[Token(Token = "0x601BA70")]
		[Address(RVA = "0x1500080", Offset = "0x14FEC80", VA = "0x181500080")]
		public static bool CheckIfSupport(RecruitGachaCostAddition.Param param)
		{
			return default(bool);
		}

		// Token: 0x0601BA71 RID: 113265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA71")]
		[Address(RVA = "0x1500130", Offset = "0x14FED30", VA = "0x181500130")]
		public void Setup(RecruitGachaCostAddition.Param param)
		{
		}

		// Token: 0x0601BA72 RID: 113266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA72")]
		[Address(RVA = "0x15002E0", Offset = "0x14FEEE0", VA = "0x1815002E0")]
		public RecruitGachaCostAddition()
		{
		}

		// Token: 0x04023E46 RID: 147014
		[Token(Token = "0x4023E46")]
		private const int COMBINE_TEN_TKT_NUM = 1;

		// Token: 0x04023E47 RID: 147015
		[Token(Token = "0x4023E47")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _batchedTktIcon;

		// Token: 0x04023E48 RID: 147016
		[Token(Token = "0x4023E48")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _batchedCount;

		// Token: 0x04023E49 RID: 147017
		[Token(Token = "0x4023E49")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _singleTenObject;

		// Token: 0x04023E4A RID: 147018
		[Token(Token = "0x4023E4A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _limitTenObject;

		// Token: 0x04023E4B RID: 147019
		[Token(Token = "0x4023E4B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _combineTenObject;

		// Token: 0x04023E4C RID: 147020
		[Token(Token = "0x4023E4C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckIfSupport;

		// Token: 0x04023E4D RID: 147021
		[Token(Token = "0x4023E4D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Setup;

		// Token: 0x04023E4E RID: 147022
		[Token(Token = "0x4023E4E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004758 RID: 18264
		[Token(Token = "0x2004758")]
		public struct Param
		{
			// Token: 0x04023E4F RID: 147023
			[Token(Token = "0x4023E4F")]
			[FieldOffset(Offset = "0x0")]
			public RecruitDataConverter.SingleGachaPolicy singlePolicy;

			// Token: 0x04023E50 RID: 147024
			[Token(Token = "0x4023E50")]
			[FieldOffset(Offset = "0x20")]
			public RecruitDataConverter.TenGachaPolicy tenPolicy;
		}
	}
}
