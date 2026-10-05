using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Building.Vault.UI
{
	// Token: 0x02001A80 RID: 6784
	[Token(Token = "0x2001A80")]
	public class VUISystem : SingletonMonoBehaviour<VUISystem>, ISingletonNotAutoCreate
	{
		// Token: 0x1700142F RID: 5167
		// (get) Token: 0x0600AAFE RID: 43774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700142F")]
		public Camera perspectiveCamera
		{
			[Token(Token = "0x600AAFE")]
			[Address(RVA = "0x32694A0", Offset = "0x32680A0", VA = "0x1832694A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001430 RID: 5168
		// (get) Token: 0x0600AAFF RID: 43775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001430")]
		public Transform orthoRoot
		{
			[Token(Token = "0x600AAFF")]
			[Address(RVA = "0x3269430", Offset = "0x3268030", VA = "0x183269430")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001431 RID: 5169
		// (get) Token: 0x0600AB00 RID: 43776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001431")]
		private VOUIOrthoPrefabConfig orthoPrefabConfig
		{
			[Token(Token = "0x600AB00")]
			[Address(RVA = "0x3269330", Offset = "0x3267F30", VA = "0x183269330")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600AB01 RID: 43777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB01")]
		[Address(RVA = "0x3266BA0", Offset = "0x32657A0", VA = "0x183266BA0", Slot = "7")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x0600AB02 RID: 43778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB02")]
		[Address(RVA = "0x3267190", Offset = "0x3265D90", VA = "0x183267190")]
		private void Update()
		{
		}

		// Token: 0x0600AB03 RID: 43779 RVA: 0x00042240 File Offset: 0x00040440
		[Token(Token = "0x600AB03")]
		[Address(RVA = "0x32668B0", Offset = "0x32654B0", VA = "0x1832668B0")]
		public Vector2 CalcPosOnPerspectiveCanvas(Vector3 target)
		{
			return default(Vector2);
		}

		// Token: 0x0600AB04 RID: 43780 RVA: 0x00042258 File Offset: 0x00040458
		[Token(Token = "0x600AB04")]
		[Address(RVA = "0x3266590", Offset = "0x3265190", VA = "0x183266590")]
		public Vector2 CalcPosOnOrthoCanvas(Vector3 target)
		{
			return default(Vector2);
		}

		// Token: 0x0600AB05 RID: 43781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB05")]
		[Address(RVA = "0x3266EA0", Offset = "0x3265AA0", VA = "0x183266EA0")]
		public void RegisterListeners()
		{
		}

		// Token: 0x0600AB06 RID: 43782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB06")]
		[Address(RVA = "0x3267C20", Offset = "0x3266820", VA = "0x183267C20")]
		private void _OnBuildingModelLoaded(object param)
		{
		}

		// Token: 0x0600AB07 RID: 43783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB07")]
		[Address(RVA = "0x3267E80", Offset = "0x3266A80", VA = "0x183267E80")]
		private void _OnVaultLayoutUpdate(object param)
		{
		}

		// Token: 0x0600AB08 RID: 43784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB08")]
		[Address(RVA = "0x32684E0", Offset = "0x32670E0", VA = "0x1832684E0")]
		private void _OnVaultRoomCharCreated(object param)
		{
		}

		// Token: 0x0600AB09 RID: 43785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB09")]
		[Address(RVA = "0x32687E0", Offset = "0x32673E0", VA = "0x1832687E0")]
		private void _OnVaultRoomFurnitureCreated(object param)
		{
		}

		// Token: 0x0600AB0A RID: 43786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB0A")]
		[Address(RVA = "0x3268040", Offset = "0x3266C40", VA = "0x183268040")]
		private void _OnVaultRoomCharChanged(object param)
		{
		}

		// Token: 0x0600AB0B RID: 43787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB0B")]
		[Address(RVA = "0x3267D00", Offset = "0x3266900", VA = "0x183267D00")]
		private void _OnFuncFurniDataUpdated(object param)
		{
		}

		// Token: 0x0600AB0C RID: 43788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB0C")]
		[Address(RVA = "0x3268B70", Offset = "0x3267770", VA = "0x183268B70")]
		private void _OnVaultRoomObjectDestroyed(object param)
		{
		}

		// Token: 0x0600AB0D RID: 43789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB0D")]
		[Address(RVA = "0x3269050", Offset = "0x3267C50", VA = "0x183269050")]
		private void _UpdateVPUI()
		{
		}

		// Token: 0x0600AB0E RID: 43790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB0E")]
		[Address(RVA = "0x32678F0", Offset = "0x32664F0", VA = "0x1832678F0")]
		private void _LoadUIFromModel(BuildingModel model)
		{
		}

		// Token: 0x0600AB0F RID: 43791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB0F")]
		[Address(RVA = "0x3268EB0", Offset = "0x3267AB0", VA = "0x183268EB0")]
		private void _UpdateVOUI()
		{
		}

		// Token: 0x0600AB10 RID: 43792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AB10")]
		[Address(RVA = "0x32675B0", Offset = "0x32661B0", VA = "0x1832675B0")]
		private VPUIPanel _CreateVPUI(RoomSlotModel slotModel)
		{
			return null;
		}

		// Token: 0x0600AB11 RID: 43793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB11")]
		[Address(RVA = "0x3268E20", Offset = "0x3267A20", VA = "0x183268E20")]
		private void _RecycleVPUI(VPUIPanel panel)
		{
		}

		// Token: 0x0600AB12 RID: 43794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AB12")]
		[Address(RVA = "0x32677B0", Offset = "0x32663B0", VA = "0x1832677B0")]
		private VPUIPanel _GetVPUIPrefab(RoomSlotModel slotModel)
		{
			return null;
		}

		// Token: 0x0600AB13 RID: 43795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB13")]
		[Address(RVA = "0x3267370", Offset = "0x3265F70", VA = "0x183267370")]
		private void _AddVOUIPanel(VOUIPanel prefab, VRoom.Object roomObject)
		{
		}

		// Token: 0x0600AB14 RID: 43796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB14")]
		[Address(RVA = "0x3268D00", Offset = "0x3267900", VA = "0x183268D00")]
		private void _RecycleVOUI(VOUIPanel panel)
		{
		}

		// Token: 0x0600AB15 RID: 43797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB15")]
		[Address(RVA = "0x32691C0", Offset = "0x3267DC0", VA = "0x1832691C0")]
		public VUISystem()
		{
		}

		// Token: 0x0400A34F RID: 41807
		[Token(Token = "0x400A34F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Perspective")]
		private Canvas _perspectiveUI;

		// Token: 0x0400A350 RID: 41808
		[Token(Token = "0x400A350")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Perspective")]
		private VPUIPanel[] _perspectiveUIPrefs;

		// Token: 0x0400A351 RID: 41809
		[Token(Token = "0x400A351")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Orthographic")]
		private RectTransform _orthoUI;

		// Token: 0x0400A352 RID: 41810
		[Token(Token = "0x400A352")]
		[FieldOffset(Offset = "0x30")]
		private Camera m_perspectiveCam;

		// Token: 0x0400A353 RID: 41811
		[Token(Token = "0x400A353")]
		[FieldOffset(Offset = "0x38")]
		private VOUIOrthoPrefabConfig m_orthoPrefabConfig;

		// Token: 0x0400A354 RID: 41812
		[Token(Token = "0x400A354")]
		[FieldOffset(Offset = "0x40")]
		private List<VUISystem.VPUIWrapper> m_VPUIs;

		// Token: 0x0400A355 RID: 41813
		[Token(Token = "0x400A355")]
		[FieldOffset(Offset = "0x48")]
		private List<VUISystem.VOUIWrapper> m_VOUIs;

		// Token: 0x0400A356 RID: 41814
		[Token(Token = "0x400A356")]
		[FieldOffset(Offset = "0x50")]
		private List<Type> m_sharedList;

		// Token: 0x0400A357 RID: 41815
		[Token(Token = "0x400A357")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_perspectiveCamera;

		// Token: 0x0400A358 RID: 41816
		[Token(Token = "0x400A358")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_orthoRoot;

		// Token: 0x0400A359 RID: 41817
		[Token(Token = "0x400A359")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_orthoPrefabConfig;

		// Token: 0x0400A35A RID: 41818
		[Token(Token = "0x400A35A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0400A35B RID: 41819
		[Token(Token = "0x400A35B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0400A35C RID: 41820
		[Token(Token = "0x400A35C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CalcPosOnPerspectiveCanvas;

		// Token: 0x0400A35D RID: 41821
		[Token(Token = "0x400A35D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CalcPosOnOrthoCanvas;

		// Token: 0x0400A35E RID: 41822
		[Token(Token = "0x400A35E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_RegisterListeners;

		// Token: 0x0400A35F RID: 41823
		[Token(Token = "0x400A35F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnBuildingModelLoaded;

		// Token: 0x0400A360 RID: 41824
		[Token(Token = "0x400A360")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnVaultLayoutUpdate;

		// Token: 0x0400A361 RID: 41825
		[Token(Token = "0x400A361")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnVaultRoomCharCreated;

		// Token: 0x0400A362 RID: 41826
		[Token(Token = "0x400A362")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnVaultRoomFurnitureCreated;

		// Token: 0x0400A363 RID: 41827
		[Token(Token = "0x400A363")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnVaultRoomCharChanged;

		// Token: 0x0400A364 RID: 41828
		[Token(Token = "0x400A364")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnFuncFurniDataUpdated;

		// Token: 0x0400A365 RID: 41829
		[Token(Token = "0x400A365")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OnVaultRoomObjectDestroyed;

		// Token: 0x0400A366 RID: 41830
		[Token(Token = "0x400A366")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__UpdateVPUI;

		// Token: 0x0400A367 RID: 41831
		[Token(Token = "0x400A367")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__LoadUIFromModel;

		// Token: 0x0400A368 RID: 41832
		[Token(Token = "0x400A368")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__UpdateVOUI;

		// Token: 0x0400A369 RID: 41833
		[Token(Token = "0x400A369")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__CreateVPUI;

		// Token: 0x0400A36A RID: 41834
		[Token(Token = "0x400A36A")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__RecycleVPUI;

		// Token: 0x0400A36B RID: 41835
		[Token(Token = "0x400A36B")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__GetVPUIPrefab;

		// Token: 0x0400A36C RID: 41836
		[Token(Token = "0x400A36C")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__AddVOUIPanel;

		// Token: 0x0400A36D RID: 41837
		[Token(Token = "0x400A36D")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__RecycleVOUI;

		// Token: 0x0400A36E RID: 41838
		[Token(Token = "0x400A36E")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001A81 RID: 6785
		[Token(Token = "0x2001A81")]
		private class VPUIWrapper : RoomSlotModel.IListener
		{
			// Token: 0x0600AB16 RID: 43798 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB16")]
			[Address(RVA = "0x3266050", Offset = "0x3264C50", VA = "0x183266050")]
			public VPUIWrapper(RoomSlotModel slotModel, VUISystem closure)
			{
			}

			// Token: 0x0600AB17 RID: 43799 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB17")]
			[Address(RVA = "0x3265D70", Offset = "0x3264970", VA = "0x183265D70", Slot = "4")]
			public void OnRegister(RoomSlotModel model)
			{
			}

			// Token: 0x0600AB18 RID: 43800 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB18")]
			[Address(RVA = "0x3265D70", Offset = "0x3264970", VA = "0x183265D70", Slot = "5")]
			public void OnContentChange(RoomSlotModel model)
			{
			}

			// Token: 0x0600AB19 RID: 43801 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB19")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
			public void OnPostLayoutContentChanged()
			{
			}

			// Token: 0x0600AB1A RID: 43802 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB1A")]
			[Address(RVA = "0x3265D80", Offset = "0x3264980", VA = "0x183265D80")]
			public void OnLayoutChange()
			{
			}

			// Token: 0x0600AB1B RID: 43803 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB1B")]
			[Address(RVA = "0x3265C70", Offset = "0x3264870", VA = "0x183265C70")]
			public void Clear()
			{
			}

			// Token: 0x0600AB1C RID: 43804 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB1C")]
			[Address(RVA = "0x3265E20", Offset = "0x3264A20", VA = "0x183265E20")]
			private void _UpdateRoomUI()
			{
			}

			// Token: 0x0400A36F RID: 41839
			[Token(Token = "0x400A36F")]
			[FieldOffset(Offset = "0x10")]
			private VUISystem m_closure;

			// Token: 0x0400A370 RID: 41840
			[Token(Token = "0x400A370")]
			[FieldOffset(Offset = "0x18")]
			private RoomSlotModel m_slotModel;

			// Token: 0x0400A371 RID: 41841
			[Token(Token = "0x400A371")]
			[FieldOffset(Offset = "0x20")]
			private VPUIPanel m_panel;
		}

		// Token: 0x02001A82 RID: 6786
		[Token(Token = "0x2001A82")]
		private class VOUIWrapper
		{
			// Token: 0x17001432 RID: 5170
			// (get) Token: 0x0600AB1D RID: 43805 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001432")]
			public VRoom.Object roomObject
			{
				[Token(Token = "0x600AB1D")]
				[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001433 RID: 5171
			// (get) Token: 0x0600AB1E RID: 43806 RVA: 0x00042270 File Offset: 0x00040470
			[Token(Token = "0x17001433")]
			public int roomObjectId
			{
				[Token(Token = "0x600AB1E")]
				[Address(RVA = "0x4EF610", Offset = "0x4EE210", VA = "0x1804EF610")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17001434 RID: 5172
			// (get) Token: 0x0600AB1F RID: 43807 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001434")]
			public VOUIPanel panel
			{
				[Token(Token = "0x600AB1F")]
				[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001435 RID: 5173
			// (get) Token: 0x0600AB20 RID: 43808 RVA: 0x00042288 File Offset: 0x00040488
			[Token(Token = "0x17001435")]
			public bool isValid
			{
				[Token(Token = "0x600AB20")]
				[Address(RVA = "0x3265740", Offset = "0x3264340", VA = "0x183265740")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600AB21 RID: 43809 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB21")]
			[Address(RVA = "0x3265670", Offset = "0x3264270", VA = "0x183265670")]
			public VOUIWrapper(VOUIPanel panelUI, VRoom.Object roomObject, VUISystem closure)
			{
			}

			// Token: 0x0600AB22 RID: 43810 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB22")]
			[Address(RVA = "0x32655D0", Offset = "0x32641D0", VA = "0x1832655D0")]
			public void Update()
			{
			}

			// Token: 0x0600AB23 RID: 43811 RVA: 0x000422A0 File Offset: 0x000404A0
			[Token(Token = "0x600AB23")]
			[Address(RVA = "0x3265510", Offset = "0x3264110", VA = "0x183265510")]
			public bool MatchObject(BuildingEvent evt, VRoom.Object roomObject)
			{
				return default(bool);
			}

			// Token: 0x0600AB24 RID: 43812 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB24")]
			[Address(RVA = "0x3265380", Offset = "0x3263F80", VA = "0x183265380")]
			public void Clear()
			{
			}

			// Token: 0x0400A372 RID: 41842
			[Token(Token = "0x400A372")]
			[FieldOffset(Offset = "0x10")]
			private VUISystem m_closure;

			// Token: 0x0400A373 RID: 41843
			[Token(Token = "0x400A373")]
			[FieldOffset(Offset = "0x18")]
			private VRoom.Object m_objInst;

			// Token: 0x0400A374 RID: 41844
			[Token(Token = "0x400A374")]
			[FieldOffset(Offset = "0x20")]
			private VOUIPanel m_panel;

			// Token: 0x0400A375 RID: 41845
			[Token(Token = "0x400A375")]
			[FieldOffset(Offset = "0x28")]
			private int m_objId;
		}
	}
}
