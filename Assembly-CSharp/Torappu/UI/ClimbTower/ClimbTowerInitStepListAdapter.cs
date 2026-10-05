using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D43 RID: 23875
	[Token(Token = "0x2005D43")]
	public class ClimbTowerInitStepListAdapter : SimpleLayoutAdapter
	{
		// Token: 0x06022927 RID: 141607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022927")]
		[Address(RVA = "0x1D1C670", Offset = "0x1D1B270", VA = "0x181D1C670")]
		public void LoadData(int stepCount, int currentStep)
		{
		}

		// Token: 0x1700515A RID: 20826
		// (get) Token: 0x06022928 RID: 141608 RVA: 0x000BDDC8 File Offset: 0x000BBFC8
		[Token(Token = "0x1700515A")]
		public override int count
		{
			[Token(Token = "0x6022928")]
			[Address(RVA = "0x1D1C920", Offset = "0x1D1B520", VA = "0x181D1C920", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06022929 RID: 141609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022929")]
		[Address(RVA = "0x1D1C700", Offset = "0x1D1B300", VA = "0x181D1C700", Slot = "5")]
		public override GameObject RenderView(int position, GameObject prefab, Transform parent)
		{
			return null;
		}

		// Token: 0x0602292A RID: 141610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602292A")]
		[Address(RVA = "0x1D1C8C0", Offset = "0x1D1B4C0", VA = "0x181D1C8C0")]
		public ClimbTowerInitStepListAdapter()
		{
		}

		// Token: 0x0402F84E RID: 194638
		[Token(Token = "0x402F84E")]
		[FieldOffset(Offset = "0x20")]
		private int m_stepCount;

		// Token: 0x0402F84F RID: 194639
		[Token(Token = "0x402F84F")]
		[FieldOffset(Offset = "0x24")]
		private int m_currentStep;

		// Token: 0x0402F850 RID: 194640
		[Token(Token = "0x402F850")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402F851 RID: 194641
		[Token(Token = "0x402F851")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_count;

		// Token: 0x0402F852 RID: 194642
		[Token(Token = "0x402F852")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x0402F853 RID: 194643
		[Token(Token = "0x402F853")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
