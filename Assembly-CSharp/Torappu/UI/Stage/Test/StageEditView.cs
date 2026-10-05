using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.Stage.Test
{
	// Token: 0x02006A43 RID: 27203
	[Token(Token = "0x2006A43")]
	public class StageEditView : MonoBehaviour, IStageMainZoneMapController
	{
		// Token: 0x06026E29 RID: 159273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026E29")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "6")]
		public UIPage GetPage()
		{
			return null;
		}

		// Token: 0x17005BB4 RID: 23476
		// (get) Token: 0x06026E2A RID: 159274 RVA: 0x000CC948 File Offset: 0x000CAB48
		[Token(Token = "0x17005BB4")]
		public float positionValue
		{
			[Token(Token = "0x6026E2A")]
			[Address(RVA = "0x738E20", Offset = "0x737A20", VA = "0x180738E20", Slot = "4")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17005BB5 RID: 23477
		// (get) Token: 0x06026E2B RID: 159275 RVA: 0x000CC960 File Offset: 0x000CAB60
		[Token(Token = "0x17005BB5")]
		public float backgroundImageRefValue
		{
			[Token(Token = "0x6026E2B")]
			[Address(RVA = "0x738E20", Offset = "0x737A20", VA = "0x180738E20", Slot = "5")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06026E2C RID: 159276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E2C")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public StageEditView()
		{
		}

		// Token: 0x04036FC5 RID: 225221
		[Token(Token = "0x4036FC5")]
		private const string ALERT_EDIT_MODE_ONLY = "请先停止运行游戏";

		// Token: 0x04036FC6 RID: 225222
		[Token(Token = "0x4036FC6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private StageDB _stageDB;

		// Token: 0x04036FC7 RID: 225223
		[Token(Token = "0x4036FC7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ZoneDB _zoneDB;

		// Token: 0x04036FC8 RID: 225224
		[Token(Token = "0x4036FC8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private StageMainZoneMap _mainZoneMapPrefab;

		// Token: 0x04036FC9 RID: 225225
		[Token(Token = "0x4036FC9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _zoneId;
	}
}
