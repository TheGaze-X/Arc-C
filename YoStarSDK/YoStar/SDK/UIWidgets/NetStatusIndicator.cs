using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using YoStar.SDK.LitJson;
using YoStar.SDK.UI;

namespace YoStar.SDK.UIWidgets
{
	// Token: 0x020000C5 RID: 197
	[Token(Token = "0x20000C5")]
	public class NetStatusIndicator : UIWidget
	{
		// Token: 0x06000539 RID: 1337 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000539")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public void OnShow(CallbackEventData eventData)
		{
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600053A")]
		[Address(RVA = "0x22F73D0", Offset = "0x22F5FD0", VA = "0x1822F73D0")]
		public void OnClose(CallbackEventData eventData)
		{
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600053B")]
		[Address(RVA = "0x5C2CD40", Offset = "0x5C2B940", VA = "0x185C2CD40", Slot = "7")]
		protected override void OnAwake()
		{
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600053C")]
		[Address(RVA = "0x5C2D2B0", Offset = "0x5C2BEB0", VA = "0x185C2D2B0", Slot = "9")]
		protected override void OnStart()
		{
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x00002A5C File Offset: 0x00000C5C
		[Token(Token = "0x600053D")]
		[Address(RVA = "0x5C2D990", Offset = "0x5C2C590", VA = "0x185C2D990", Slot = "14")]
		public virtual bool UpdataNetworkType(NetworkType networkType)
		{
			return default(bool);
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600053E")]
		[Address(RVA = "0x5C2D370", Offset = "0x5C2BF70", VA = "0x185C2D370", Slot = "15")]
		public virtual void StartNetCheck(NetworkType networkType)
		{
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600053F")]
		[Address(RVA = "0x5C2D4E0", Offset = "0x5C2C0E0", VA = "0x185C2D4E0", Slot = "16")]
		public virtual void StopNetCheck(JsonData data)
		{
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000540")]
		[Address(RVA = "0x22F8A50", Offset = "0x22F7650", VA = "0x1822F8A50", Slot = "17")]
		public virtual void CloseView(UnityAction action)
		{
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000541")]
		[Address(RVA = "0x5C2D770", Offset = "0x5C2C370", VA = "0x185C2D770")]
		private void UpdataItems(JsonData data)
		{
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000542")]
		[Address(RVA = "0x5C2CA20", Offset = "0x5C2B620", VA = "0x185C2CA20")]
		private void ItemAnimator(bool isStart)
		{
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000543")]
		[Address(RVA = "0x5C2C980", Offset = "0x5C2B580", VA = "0x185C2C980")]
		private void HideWifiGroup()
		{
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000544")]
		[Address(RVA = "0x5C2D2D0", Offset = "0x5C2BED0", VA = "0x185C2D2D0")]
		private void ShowWifiGroup()
		{
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000545")]
		[Address(RVA = "0x5C2C400", Offset = "0x5C2B000", VA = "0x185C2C400")]
		private void AnimateYPosition(float duration, float value, float alpha, UnityAction action)
		{
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000546")]
		[Address(RVA = "0x5C2C700", Offset = "0x5C2B300", VA = "0x185C2C700")]
		private void CreateItems(JsonData data)
		{
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000547")]
		[Address(RVA = "0x5C2C620", Offset = "0x5C2B220", VA = "0x185C2C620")]
		private GameObject CreateItem(JsonData data)
		{
			return null;
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000548")]
		[Address(RVA = "0x5C2DB80", Offset = "0x5C2C780", VA = "0x185C2DB80")]
		public NetStatusIndicator()
		{
		}

		// Token: 0x040002D3 RID: 723
		[Token(Token = "0x40002D3")]
		[FieldOffset(Offset = "0x88")]
		private CustomButton startButton;

		// Token: 0x040002D4 RID: 724
		[Token(Token = "0x40002D4")]
		[FieldOffset(Offset = "0x90")]
		private RectTransform middleGroupRect;

		// Token: 0x040002D5 RID: 725
		[Token(Token = "0x40002D5")]
		[FieldOffset(Offset = "0x98")]
		private Text netTypeText;

		// Token: 0x040002D6 RID: 726
		[Token(Token = "0x40002D6")]
		[FieldOffset(Offset = "0xA0")]
		public JsonData dataSource;

		// Token: 0x040002D7 RID: 727
		[Token(Token = "0x40002D7")]
		[FieldOffset(Offset = "0xA8")]
		private List<GameObject> canvasCache;

		// Token: 0x040002D8 RID: 728
		[Token(Token = "0x40002D8")]
		[FieldOffset(Offset = "0xB0")]
		private GameObject netStatusItemPrefab;

		// Token: 0x040002D9 RID: 729
		[Token(Token = "0x40002D9")]
		[FieldOffset(Offset = "0xB8")]
		private CanvasGroup wifiGroupCanvas;

		// Token: 0x040002DA RID: 730
		[Token(Token = "0x40002DA")]
		[FieldOffset(Offset = "0xC0")]
		private UnityAction closeAction;
	}
}
