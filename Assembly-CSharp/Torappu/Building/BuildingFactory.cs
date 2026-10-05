using System;
using Il2CppDummyDll;
using Torappu.Building.BP;
using Torappu.Building.Vault;
using Torappu.Resource;
using UnityEngine;
using XLua;

namespace Torappu.Building
{
	// Token: 0x020017CD RID: 6093
	[Token(Token = "0x20017CD")]
	public class BuildingFactory : SingletonMonoBehaviour<BuildingFactory>, IHotfixable
	{
		// Token: 0x170010AF RID: 4271
		// (get) Token: 0x060099EF RID: 39407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010AF")]
		private AbstractAssetLoader directAssetLoader
		{
			[Token(Token = "0x60099EF")]
			[Address(RVA = "0x313B130", Offset = "0x3139D30", VA = "0x18313B130")]
			get
			{
				return null;
			}
		}

		// Token: 0x060099F0 RID: 39408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099F0")]
		[Address(RVA = "0x313AFD0", Offset = "0x3139BD0", VA = "0x18313AFD0")]
		public BuildingFactory()
		{
		}

		// Token: 0x060099F1 RID: 39409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60099F1")]
		public T Load<T>(string path) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x060099F2 RID: 39410 RVA: 0x0003BC10 File Offset: 0x00039E10
		[Token(Token = "0x60099F2")]
		public bool TryLoad<T>(string path, out T obj) where T : UnityEngine.Object
		{
			return default(bool);
		}

		// Token: 0x060099F3 RID: 39411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60099F3")]
		[Address(RVA = "0x313ABD0", Offset = "0x31397D0", VA = "0x18313ABD0")]
		public IDynamicAssetHandler LoadAssetWithWrapper(string path, IDynamicAssetWrapper assetWrapper)
		{
			return null;
		}

		// Token: 0x060099F4 RID: 39412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60099F4")]
		[Address(RVA = "0x313A500", Offset = "0x3139100", VA = "0x18313A500")]
		public BRoomSlot CreateBRoomSlot(Transform parent)
		{
			return null;
		}

		// Token: 0x060099F5 RID: 39413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60099F5")]
		[Address(RVA = "0x313A650", Offset = "0x3139250", VA = "0x18313A650")]
		public BRoom CreateBRoom(string roomId, Transform parent)
		{
			return null;
		}

		// Token: 0x060099F6 RID: 39414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60099F6")]
		[Address(RVA = "0x313A3B0", Offset = "0x3138FB0", VA = "0x18313A3B0")]
		public BRoomHilightContainer CreateBRoomSlotHilight()
		{
			return null;
		}

		// Token: 0x060099F7 RID: 39415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60099F7")]
		[Address(RVA = "0x313AA70", Offset = "0x3139670", VA = "0x18313AA70")]
		public VRoom CreateVRoom(string roomId, Transform parent)
		{
			return null;
		}

		// Token: 0x060099F8 RID: 39416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60099F8")]
		[Address(RVA = "0x313A960", Offset = "0x3139560", VA = "0x18313A960")]
		public VDoor CreateVDoor(string doorId, Transform parent)
		{
			return null;
		}

		// Token: 0x060099F9 RID: 39417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099F9")]
		[Address(RVA = "0x313A7B0", Offset = "0x31393B0", VA = "0x18313A7B0")]
		public void CreateVCharacterAsync(CharUISkinStruct skinStruct, Transform parent, Action<VCharacter> cb)
		{
		}

		// Token: 0x060099FA RID: 39418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099FA")]
		[Address(RVA = "0x313AD70", Offset = "0x3139970", VA = "0x18313AD70")]
		public void OnStart()
		{
		}

		// Token: 0x060099FB RID: 39419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099FB")]
		[Address(RVA = "0x313AC70", Offset = "0x3139870", VA = "0x18313AC70")]
		public void OnBuildingModeChanged()
		{
		}

		// Token: 0x060099FC RID: 39420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099FC")]
		[Address(RVA = "0x313A2E0", Offset = "0x3138EE0", VA = "0x18313A2E0")]
		public void ClearTasksAndStay()
		{
		}

		// Token: 0x060099FD RID: 39421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099FD")]
		[Address(RVA = "0x313AEC0", Offset = "0x3139AC0", VA = "0x18313AEC0")]
		private void _CheckIsPauseForSplitFrameLoader()
		{
		}

		// Token: 0x060099FE RID: 39422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099FE")]
		[Address(RVA = "0x313ACD0", Offset = "0x31398D0", VA = "0x18313ACD0", Slot = "7")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x060099FF RID: 39423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099FF")]
		[Address(RVA = "0x313AE40", Offset = "0x3139A40", VA = "0x18313AE40")]
		private void Update()
		{
		}

		// Token: 0x04009083 RID: 36995
		[Token(Token = "0x4009083")]
		[FieldOffset(Offset = "0x18")]
		private GameObjectSplitFrameLoadBalancer m_loadBalancer;

		// Token: 0x04009084 RID: 36996
		[Token(Token = "0x4009084")]
		[FieldOffset(Offset = "0x20")]
		private GameObjectSplitFrameLoadBalancer m_loadBalancerVModeOnly;

		// Token: 0x04009085 RID: 36997
		[Token(Token = "0x4009085")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_directAssetLoader;

		// Token: 0x04009086 RID: 36998
		[Token(Token = "0x4009086")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04009087 RID: 36999
		[Token(Token = "0x4009087")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Load;

		// Token: 0x04009088 RID: 37000
		[Token(Token = "0x4009088")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_TryLoad;

		// Token: 0x04009089 RID: 37001
		[Token(Token = "0x4009089")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadAssetWithWrapper;

		// Token: 0x0400908A RID: 37002
		[Token(Token = "0x400908A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CreateBRoomSlot;

		// Token: 0x0400908B RID: 37003
		[Token(Token = "0x400908B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CreateBRoom;

		// Token: 0x0400908C RID: 37004
		[Token(Token = "0x400908C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CreateBRoomSlotHilight;

		// Token: 0x0400908D RID: 37005
		[Token(Token = "0x400908D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CreateVRoom;

		// Token: 0x0400908E RID: 37006
		[Token(Token = "0x400908E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_CreateVDoor;

		// Token: 0x0400908F RID: 37007
		[Token(Token = "0x400908F")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_CreateVCharacterAsync;

		// Token: 0x04009090 RID: 37008
		[Token(Token = "0x4009090")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnStart;

		// Token: 0x04009091 RID: 37009
		[Token(Token = "0x4009091")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnBuildingModeChanged;

		// Token: 0x04009092 RID: 37010
		[Token(Token = "0x4009092")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_ClearTasksAndStay;

		// Token: 0x04009093 RID: 37011
		[Token(Token = "0x4009093")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__CheckIsPauseForSplitFrameLoader;

		// Token: 0x04009094 RID: 37012
		[Token(Token = "0x4009094")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04009095 RID: 37013
		[Token(Token = "0x4009095")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_Update;
	}
}
