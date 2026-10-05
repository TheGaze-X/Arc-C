using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.BP
{
	// Token: 0x02001AA5 RID: 6821
	[Token(Token = "0x2001AA5")]
	public class BRoom : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700145C RID: 5212
		// (get) Token: 0x0600AC09 RID: 44041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700145C")]
		protected BRoomSlot roomSlot
		{
			[Token(Token = "0x600AC09")]
			[Address(RVA = "0x3276E30", Offset = "0x3275A30", VA = "0x183276E30")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700145D RID: 5213
		// (get) Token: 0x0600AC0A RID: 44042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700145D")]
		public RoomSlotModel roomSlotModel
		{
			[Token(Token = "0x600AC0A")]
			[Address(RVA = "0x3276DD0", Offset = "0x32759D0", VA = "0x183276DD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700145E RID: 5214
		// (get) Token: 0x0600AC0B RID: 44043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700145E")]
		protected BLayoutManager layout
		{
			[Token(Token = "0x600AC0B")]
			[Address(RVA = "0x3276C90", Offset = "0x3275890", VA = "0x183276C90")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600AC0C RID: 44044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AC0C")]
		[Address(RVA = "0x326C700", Offset = "0x326B300", VA = "0x18326C700", Slot = "4")]
		public virtual Action<object> ListenerToPlayerData()
		{
			return null;
		}

		// Token: 0x0600AC0D RID: 44045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC0D")]
		[Address(RVA = "0x3276A80", Offset = "0x3275680", VA = "0x183276A80")]
		public void UpdateLevelupIcon()
		{
		}

		// Token: 0x0600AC0E RID: 44046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC0E")]
		[Address(RVA = "0x3276630", Offset = "0x3275230", VA = "0x183276630")]
		public void Init(BRoomSlot roomSlot, RoomSlotModel slotModel)
		{
		}

		// Token: 0x0600AC0F RID: 44047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC0F")]
		[Address(RVA = "0x32768E0", Offset = "0x32754E0", VA = "0x1832768E0")]
		public void UpdateContent(RoomSlotModel slotModel)
		{
		}

		// Token: 0x0600AC10 RID: 44048 RVA: 0x000427E0 File Offset: 0x000409E0
		[Token(Token = "0x600AC10")]
		[Address(RVA = "0x32765B0", Offset = "0x32751B0", VA = "0x1832765B0")]
		public bool ClickRoom()
		{
			return default(bool);
		}

		// Token: 0x0600AC11 RID: 44049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC11")]
		[Address(RVA = "0x3276490", Offset = "0x3275090", VA = "0x183276490")]
		public void ActiveArchitecture(bool active)
		{
		}

		// Token: 0x0600AC12 RID: 44050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC12")]
		[Address(RVA = "0x3276860", Offset = "0x3275460", VA = "0x183276860")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600AC13 RID: 44051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC13")]
		[Address(RVA = "0x326BE80", Offset = "0x326AA80", VA = "0x18326BE80", Slot = "5")]
		protected virtual void OnInit(BRoomSlot roomSlot, RoomSlotModel slotModel)
		{
		}

		// Token: 0x0600AC14 RID: 44052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC14")]
		[Address(RVA = "0x326BE20", Offset = "0x326AA20", VA = "0x18326BE20", Slot = "6")]
		protected virtual void OnContentChanged(RoomSlotModel slotModel)
		{
		}

		// Token: 0x0600AC15 RID: 44053 RVA: 0x000427F8 File Offset: 0x000409F8
		[Token(Token = "0x600AC15")]
		[Address(RVA = "0x32711F0", Offset = "0x326FDF0", VA = "0x1832711F0", Slot = "7")]
		protected virtual bool OnRoomClicked()
		{
			return default(bool);
		}

		// Token: 0x0600AC16 RID: 44054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC16")]
		[Address(RVA = "0x326BF00", Offset = "0x326AB00", VA = "0x18326BF00", Slot = "8")]
		protected virtual void OnRoomDestroy()
		{
		}

		// Token: 0x1700145F RID: 5215
		// (get) Token: 0x0600AC17 RID: 44055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700145F")]
		protected virtual string roomName
		{
			[Token(Token = "0x600AC17")]
			[Address(RVA = "0x3276D40", Offset = "0x3275940", VA = "0x183276D40", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600AC18 RID: 44056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC18")]
		[Address(RVA = "0x32767B0", Offset = "0x32753B0", VA = "0x1832767B0", Slot = "10")]
		protected virtual void OnActiveArchitecture(bool active, [Optional] Func<RoomSlotModel, bool> validPred)
		{
		}

		// Token: 0x0600AC19 RID: 44057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC19")]
		[Address(RVA = "0x3276C30", Offset = "0x3275830", VA = "0x183276C30")]
		public BRoom()
		{
		}

		// Token: 0x0400A431 RID: 42033
		[Token(Token = "0x400A431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0400A432 RID: 42034
		[Token(Token = "0x400A432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelArchitectOnly;

		// Token: 0x0400A433 RID: 42035
		[Token(Token = "0x400A433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelNormalOnly;

		// Token: 0x0400A434 RID: 42036
		[Token(Token = "0x400A434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _canLevelupIcon;

		// Token: 0x0400A435 RID: 42037
		[Token(Token = "0x400A435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private BRoomSlot m_roomSlot;

		// Token: 0x0400A436 RID: 42038
		[Token(Token = "0x400A436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RoomSlotModel m_roomSlotModel;

		// Token: 0x0400A437 RID: 42039
		[Token(Token = "0x400A437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool m_inArchitecture;

		// Token: 0x0400A438 RID: 42040
		[Token(Token = "0x400A438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_roomSlot;

		// Token: 0x0400A439 RID: 42041
		[Token(Token = "0x400A439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_roomSlotModel;

		// Token: 0x0400A43A RID: 42042
		[Token(Token = "0x400A43A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_layout;

		// Token: 0x0400A43B RID: 42043
		[Token(Token = "0x400A43B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ListenerToPlayerData;

		// Token: 0x0400A43C RID: 42044
		[Token(Token = "0x400A43C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdateLevelupIcon;

		// Token: 0x0400A43D RID: 42045
		[Token(Token = "0x400A43D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400A43E RID: 42046
		[Token(Token = "0x400A43E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_UpdateContent;

		// Token: 0x0400A43F RID: 42047
		[Token(Token = "0x400A43F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ClickRoom;

		// Token: 0x0400A440 RID: 42048
		[Token(Token = "0x400A440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ActiveArchitecture;

		// Token: 0x0400A441 RID: 42049
		[Token(Token = "0x400A441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0400A442 RID: 42050
		[Token(Token = "0x400A442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400A443 RID: 42051
		[Token(Token = "0x400A443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnContentChanged;

		// Token: 0x0400A444 RID: 42052
		[Token(Token = "0x400A444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnRoomClicked;

		// Token: 0x0400A445 RID: 42053
		[Token(Token = "0x400A445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnRoomDestroy;

		// Token: 0x0400A446 RID: 42054
		[Token(Token = "0x400A446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_roomName;

		// Token: 0x0400A447 RID: 42055
		[Token(Token = "0x400A447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnActiveArchitecture;

		// Token: 0x0400A448 RID: 42056
		[Token(Token = "0x400A448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
