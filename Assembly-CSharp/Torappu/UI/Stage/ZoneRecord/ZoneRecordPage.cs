using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage.ZoneRecord
{
	// Token: 0x02006A04 RID: 27140
	[Token(Token = "0x2006A04")]
	public class ZoneRecordPage : StateEnginePage, IHotfixable
	{
		// Token: 0x06026CDF RID: 158943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026CDF")]
		[Address(RVA = "0x21E16C0", Offset = "0x21E02C0", VA = "0x1821E16C0", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x06026CE0 RID: 158944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026CE0")]
		[Address(RVA = "0x21E17A0", Offset = "0x21E03A0", VA = "0x1821E17A0", Slot = "28")]
		protected override void OnStateEngineReady(bool isFromStack)
		{
		}

		// Token: 0x06026CE1 RID: 158945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026CE1")]
		[Address(RVA = "0x21E1740", Offset = "0x21E0340", VA = "0x1821E1740", Slot = "17")]
		protected override void OnPageRouted()
		{
		}

		// Token: 0x17005B97 RID: 23447
		// (get) Token: 0x06026CE2 RID: 158946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005B97")]
		public RectTransform controllerContainer
		{
			[Token(Token = "0x6026CE2")]
			[Address(RVA = "0x21E1D70", Offset = "0x21E0970", VA = "0x1821E1D70")]
			get
			{
				return null;
			}
		}

		// Token: 0x06026CE3 RID: 158947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026CE3")]
		[Address(RVA = "0x21E15B0", Offset = "0x21E01B0", VA = "0x1821E15B0")]
		public void OnBackClicked()
		{
		}

		// Token: 0x06026CE4 RID: 158948 RVA: 0x000CC6C0 File Offset: 0x000CA8C0
		[Token(Token = "0x6026CE4")]
		[Address(RVA = "0x21E1380", Offset = "0x21DFF80", VA = "0x1821E1380")]
		public bool IsTransitting()
		{
			return default(bool);
		}

		// Token: 0x06026CE5 RID: 158949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026CE5")]
		[Address(RVA = "0x21E1820", Offset = "0x21E0420", VA = "0x1821E1820")]
		public static void SendGetZoneRecordReward(string[] stageIds, Action<ZoneRecordRewardResponse> handler)
		{
		}

		// Token: 0x06026CE6 RID: 158950 RVA: 0x000CC6D8 File Offset: 0x000CA8D8
		[Token(Token = "0x6026CE6")]
		public bool LoadAsset<T>(string assetPath, out T asset) where T : UnityEngine.Object
		{
			return default(bool);
		}

		// Token: 0x06026CE7 RID: 158951 RVA: 0x000CC6F0 File Offset: 0x000CA8F0
		[Token(Token = "0x6026CE7")]
		[Address(RVA = "0x21E1410", Offset = "0x21E0010", VA = "0x1821E1410")]
		public bool LoadSpriteFromAutoPackHub(string spriteId, string hubPath, out Sprite sprite)
		{
			return default(bool);
		}

		// Token: 0x06026CE8 RID: 158952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026CE8")]
		[Address(RVA = "0x21E1A70", Offset = "0x21E0670", VA = "0x1821E1A70")]
		public string TryLoadTextAssets(string path)
		{
			return null;
		}

		// Token: 0x06026CE9 RID: 158953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026CE9")]
		[Address(RVA = "0x21E1C40", Offset = "0x21E0840", VA = "0x1821E1C40")]
		private static IEnumerator _ReceiveItemsCoroutine(List<ItemGet> rewardList, Action onConfirm)
		{
			return null;
		}

		// Token: 0x06026CEA RID: 158954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026CEA")]
		[Address(RVA = "0x21E1D10", Offset = "0x21E0910", VA = "0x1821E1D10")]
		public ZoneRecordPage()
		{
		}

		// Token: 0x06026CEB RID: 158955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026CEB")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x06026CEC RID: 158956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026CEC")]
		[Address(RVA = "0x1232DA0", Offset = "0x12319A0", VA = "0x181232DA0")]
		private void <>xLuaBaseProxy_OnStateEngineReady(bool P0)
		{
		}

		// Token: 0x06026CED RID: 158957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026CED")]
		[Address(RVA = "0xF93B60", Offset = "0xF92760", VA = "0x180F93B60")]
		private void <>xLuaBaseProxy_OnPageRouted()
		{
		}

		// Token: 0x04036D24 RID: 224548
		[Token(Token = "0x4036D24")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private RectTransform _recordHolderContainer;

		// Token: 0x04036D25 RID: 224549
		[Token(Token = "0x4036D25")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x04036D26 RID: 224550
		[Token(Token = "0x4036D26")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnStateEngineReady;

		// Token: 0x04036D27 RID: 224551
		[Token(Token = "0x4036D27")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnPageRouted;

		// Token: 0x04036D28 RID: 224552
		[Token(Token = "0x4036D28")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_controllerContainer;

		// Token: 0x04036D29 RID: 224553
		[Token(Token = "0x4036D29")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnBackClicked;

		// Token: 0x04036D2A RID: 224554
		[Token(Token = "0x4036D2A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_IsTransitting;

		// Token: 0x04036D2B RID: 224555
		[Token(Token = "0x4036D2B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SendGetZoneRecordReward;

		// Token: 0x04036D2C RID: 224556
		[Token(Token = "0x4036D2C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_LoadAsset;

		// Token: 0x04036D2D RID: 224557
		[Token(Token = "0x4036D2D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_LoadSpriteFromAutoPackHub;

		// Token: 0x04036D2E RID: 224558
		[Token(Token = "0x4036D2E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_TryLoadTextAssets;

		// Token: 0x04036D2F RID: 224559
		[Token(Token = "0x4036D2F")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ReceiveItemsCoroutine;

		// Token: 0x04036D30 RID: 224560
		[Token(Token = "0x4036D30")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006A05 RID: 27141
		[Token(Token = "0x2006A05")]
		public class Params
		{
			// Token: 0x06026CEE RID: 158958 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026CEE")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Params()
			{
			}

			// Token: 0x04036D31 RID: 224561
			[Token(Token = "0x4036D31")]
			[FieldOffset(Offset = "0x10")]
			public string zoneId;
		}
	}
}
