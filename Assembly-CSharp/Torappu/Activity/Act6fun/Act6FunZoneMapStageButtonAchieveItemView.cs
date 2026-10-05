using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act6fun
{
	// Token: 0x020071C7 RID: 29127
	[Token(Token = "0x20071C7")]
	public class Act6FunZoneMapStageButtonAchieveItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06029559 RID: 169305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029559")]
		[Address(RVA = "0x24B5160", Offset = "0x24B3D60", VA = "0x1824B5160")]
		public void Render(int curGetCount, int maxCount)
		{
		}

		// Token: 0x0602955A RID: 169306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602955A")]
		[Address(RVA = "0x24B52F0", Offset = "0x24B3EF0", VA = "0x1824B52F0")]
		public Act6FunZoneMapStageButtonAchieveItemView()
		{
		}

		// Token: 0x0403B07E RID: 241790
		[Token(Token = "0x403B07E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _objAchieveThreePart;

		// Token: 0x0403B07F RID: 241791
		[Token(Token = "0x403B07F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<GameObject> _objAchieveThreeList;

		// Token: 0x0403B080 RID: 241792
		[Token(Token = "0x403B080")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _objAchieveTwoPart;

		// Token: 0x0403B081 RID: 241793
		[Token(Token = "0x403B081")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<GameObject> _objAchieveTwoList;

		// Token: 0x0403B082 RID: 241794
		[Token(Token = "0x403B082")]
		private const int MAX_ACHIEVE_THREE = 3;

		// Token: 0x0403B083 RID: 241795
		[Token(Token = "0x403B083")]
		private const int MAX_ACHIEVE_TWO = 2;

		// Token: 0x0403B084 RID: 241796
		[Token(Token = "0x403B084")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403B085 RID: 241797
		[Token(Token = "0x403B085")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
