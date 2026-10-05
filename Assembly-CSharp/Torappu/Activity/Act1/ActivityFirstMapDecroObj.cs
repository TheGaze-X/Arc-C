using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1
{
	// Token: 0x02007B56 RID: 31574
	[Token(Token = "0x2007B56")]
	public class ActivityFirstMapDecroObj : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602C32A RID: 181034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C32A")]
		[Address(RVA = "0x281BC90", Offset = "0x281A890", VA = "0x18281BC90")]
		public void InitData(DefaultZoneData zoneData)
		{
		}

		// Token: 0x0602C32B RID: 181035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C32B")]
		[Address(RVA = "0x281BD60", Offset = "0x281A960", VA = "0x18281BD60")]
		public void OnSelect(string selectId)
		{
		}

		// Token: 0x0602C32C RID: 181036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C32C")]
		[Address(RVA = "0x281BDF0", Offset = "0x281A9F0", VA = "0x18281BDF0")]
		public ActivityFirstMapDecroObj()
		{
		}

		// Token: 0x04040115 RID: 262421
		[Token(Token = "0x4040115")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _zoneIndex;

		// Token: 0x04040116 RID: 262422
		[Token(Token = "0x4040116")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _selectedPart;

		// Token: 0x04040117 RID: 262423
		[Token(Token = "0x4040117")]
		[FieldOffset(Offset = "0x28")]
		private string m_zoneCacheId;

		// Token: 0x04040118 RID: 262424
		[Token(Token = "0x4040118")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x04040119 RID: 262425
		[Token(Token = "0x4040119")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnSelect;

		// Token: 0x0404011A RID: 262426
		[Token(Token = "0x404011A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
