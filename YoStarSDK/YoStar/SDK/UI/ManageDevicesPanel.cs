using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YoStar.SDK.Bean;

namespace YoStar.SDK.UI
{
	// Token: 0x0200017F RID: 383
	[Token(Token = "0x200017F")]
	public class ManageDevicesPanel : BasePanel
	{
		// Token: 0x06000996 RID: 2454 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000996")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
		public override void InitView()
		{
		}

		// Token: 0x06000997 RID: 2455 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000997")]
		[Address(RVA = "0x5C6F2F0", Offset = "0x5C6DEF0", VA = "0x185C6F2F0")]
		private void Start()
		{
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000998")]
		[Address(RVA = "0x5C6EC80", Offset = "0x5C6D880", VA = "0x185C6EC80")]
		private void FindComponent()
		{
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000999")]
		[Address(RVA = "0x5C6F150", Offset = "0x5C6DD50", VA = "0x185C6F150", Slot = "9")]
		public override void OnCreate()
		{
		}

		// Token: 0x0600099A RID: 2458 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600099A")]
		[Address(RVA = "0x5C6E130", Offset = "0x5C6CD30", VA = "0x185C6E130")]
		private void CreateData()
		{
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600099B")]
		[Address(RVA = "0x5C6F270", Offset = "0x5C6DE70", VA = "0x185C6F270")]
		private IEnumerator RefreshAfterFirstFrame()
		{
			return null;
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600099C")]
		[Address(RVA = "0x5C6E1D0", Offset = "0x5C6CDD0", VA = "0x185C6E1D0")]
		private void CreateDevicesItem()
		{
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600099D")]
		[Address(RVA = "0x5C6E9C0", Offset = "0x5C6D5C0", VA = "0x185C6E9C0")]
		private void Delete(string currentID, string currentDeviceID)
		{
		}

		// Token: 0x0600099E RID: 2462 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600099E")]
		[Address(RVA = "0x5C6DFE0", Offset = "0x5C6CBE0", VA = "0x185C6DFE0")]
		public void ClearRows()
		{
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600099F")]
		[Address(RVA = "0x5B5830", Offset = "0x5B4430", VA = "0x1805B5830")]
		public ManageDevicesPanel()
		{
		}

		// Token: 0x04000609 RID: 1545
		[Token(Token = "0x4000609")]
		private const string DEVICE_ANDROID = "android";

		// Token: 0x0400060A RID: 1546
		[Token(Token = "0x400060A")]
		private const string DEVICE_IOS = "ios";

		// Token: 0x0400060B RID: 1547
		[Token(Token = "0x400060B")]
		private const string DEVICE_PC = "pc";

		// Token: 0x0400060C RID: 1548
		[Token(Token = "0x400060C")]
		private const string DEVICE_WEB = "web";

		// Token: 0x0400060D RID: 1549
		[Token(Token = "0x400060D")]
		private const string DEVICE_STEAM = "steam";

		// Token: 0x0400060E RID: 1550
		[Token(Token = "0x400060E")]
		[FieldOffset(Offset = "0x50")]
		private GameObject content;

		// Token: 0x0400060F RID: 1551
		[Token(Token = "0x400060F")]
		[FieldOffset(Offset = "0x58")]
		private List<ManageDevicesItem> itemList;

		// Token: 0x04000610 RID: 1552
		[Token(Token = "0x4000610")]
		[FieldOffset(Offset = "0x60")]
		private List<GameObject> userItems;
	}
}
