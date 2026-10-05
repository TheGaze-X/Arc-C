using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1
{
	// Token: 0x02007B58 RID: 31576
	[Token(Token = "0x2007B58")]
	public class ActivityFirstMicroMapObj : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602C32E RID: 181038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C32E")]
		[Address(RVA = "0x281D110", Offset = "0x281BD10", VA = "0x18281D110")]
		public void InitData(DefaultZoneData zoneData)
		{
		}

		// Token: 0x0602C32F RID: 181039 RVA: 0x000DE600 File Offset: 0x000DC800
		[Token(Token = "0x602C32F")]
		[Address(RVA = "0x281D2B0", Offset = "0x281BEB0", VA = "0x18281D2B0")]
		public bool SelectState(string selectedId)
		{
			return default(bool);
		}

		// Token: 0x0602C330 RID: 181040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C330")]
		[Address(RVA = "0x281D230", Offset = "0x281BE30", VA = "0x18281D230")]
		public void OnClick()
		{
		}

		// Token: 0x0602C331 RID: 181041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C331")]
		[Address(RVA = "0x281D350", Offset = "0x281BF50", VA = "0x18281D350")]
		public ActivityFirstMicroMapObj()
		{
		}

		// Token: 0x0404011C RID: 262428
		[Token(Token = "0x404011C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textTitle;

		// Token: 0x0404011D RID: 262429
		[Token(Token = "0x404011D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _zoneIndex;

		// Token: 0x0404011E RID: 262430
		[Token(Token = "0x404011E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _selected;

		// Token: 0x0404011F RID: 262431
		[Token(Token = "0x404011F")]
		[FieldOffset(Offset = "0x30")]
		private string m_cacheZoneId;

		// Token: 0x04040120 RID: 262432
		[Token(Token = "0x4040120")]
		[FieldOffset(Offset = "0x38")]
		[NonSerialized]
		public UIStringEvent stringEvent;

		// Token: 0x04040121 RID: 262433
		[Token(Token = "0x4040121")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x04040122 RID: 262434
		[Token(Token = "0x4040122")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SelectState;

		// Token: 0x04040123 RID: 262435
		[Token(Token = "0x4040123")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x04040124 RID: 262436
		[Token(Token = "0x4040124")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
