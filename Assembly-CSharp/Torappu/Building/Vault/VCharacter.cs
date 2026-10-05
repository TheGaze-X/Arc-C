using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Spine;
using Spine.Unity;
using UnityEngine;
using XLua;

namespace Torappu.Building.Vault
{
	// Token: 0x02001A16 RID: 6678
	[Token(Token = "0x2001A16")]
	public class VCharacter : VRoom.Object, IMovable
	{
		// Token: 0x17001355 RID: 4949
		// (get) Token: 0x0600A768 RID: 42856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001355")]
		protected Bone shadowFollowBone
		{
			[Token(Token = "0x600A768")]
			[Address(RVA = "0x322E260", Offset = "0x322CE60", VA = "0x18322E260")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001356 RID: 4950
		// (get) Token: 0x0600A769 RID: 42857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001356")]
		protected Slot shadowAlphaSourceSlot
		{
			[Token(Token = "0x600A769")]
			[Address(RVA = "0x322E1A0", Offset = "0x322CDA0", VA = "0x18322E1A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001357 RID: 4951
		// (get) Token: 0x0600A76A RID: 42858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001357")]
		private SpriteRenderer shadowRenderer
		{
			[Token(Token = "0x600A76A")]
			[Address(RVA = "0x322E320", Offset = "0x322CF20", VA = "0x18322E320")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001358 RID: 4952
		// (get) Token: 0x0600A76B RID: 42859 RVA: 0x00040C98 File Offset: 0x0003EE98
		// (set) Token: 0x0600A76C RID: 42860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001358")]
		public bool inControl
		{
			[Token(Token = "0x600A76B")]
			[Address(RVA = "0x322DA20", Offset = "0x322C620", VA = "0x18322DA20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600A76C")]
			[Address(RVA = "0x322E920", Offset = "0x322D520", VA = "0x18322E920")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17001359 RID: 4953
		// (get) Token: 0x0600A76D RID: 42861 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600A76E RID: 42862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001359")]
		public VFurnitureBridge.InteractSlot interactingSlot
		{
			[Token(Token = "0x600A76D")]
			[Address(RVA = "0x322DB90", Offset = "0x322C790", VA = "0x18322DB90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600A76E")]
			[Address(RVA = "0x322E990", Offset = "0x322D590", VA = "0x18322E990")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700135A RID: 4954
		// (get) Token: 0x0600A76F RID: 42863 RVA: 0x00040CB0 File Offset: 0x0003EEB0
		[Token(Token = "0x1700135A")]
		public bool interactingSlotValid
		{
			[Token(Token = "0x600A76F")]
			[Address(RVA = "0x322DA80", Offset = "0x322C680", VA = "0x18322DA80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700135B RID: 4955
		// (get) Token: 0x0600A770 RID: 42864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700135B")]
		public VMoveController moveController
		{
			[Token(Token = "0x600A770")]
			[Address(RVA = "0x322E000", Offset = "0x322CC00", VA = "0x18322E000")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700135C RID: 4956
		// (get) Token: 0x0600A771 RID: 42865 RVA: 0x00040CC8 File Offset: 0x0003EEC8
		// (set) Token: 0x0600A772 RID: 42866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700135C")]
		public bool hideOutline
		{
			[Token(Token = "0x600A771")]
			[Address(RVA = "0x322D9C0", Offset = "0x322C5C0", VA = "0x18322D9C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600A772")]
			[Address(RVA = "0x322E8B0", Offset = "0x322D4B0", VA = "0x18322E8B0")]
			set
			{
			}
		}

		// Token: 0x1700135D RID: 4957
		// (get) Token: 0x0600A773 RID: 42867 RVA: 0x00040CE0 File Offset: 0x0003EEE0
		[Token(Token = "0x1700135D")]
		public bool isInCFurnitureState
		{
			[Token(Token = "0x600A773")]
			[Address(RVA = "0x322DBF0", Offset = "0x322C7F0", VA = "0x18322DBF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700135E RID: 4958
		// (get) Token: 0x0600A774 RID: 42868 RVA: 0x00040CF8 File Offset: 0x0003EEF8
		[Token(Token = "0x1700135E")]
		public bool isInCSpecialState
		{
			[Token(Token = "0x600A774")]
			[Address(RVA = "0x322DCE0", Offset = "0x322C8E0", VA = "0x18322DCE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700135F RID: 4959
		// (get) Token: 0x0600A775 RID: 42869 RVA: 0x00040D10 File Offset: 0x0003EF10
		[Token(Token = "0x1700135F")]
		public bool isInCNormalState
		{
			[Token(Token = "0x600A775")]
			[Address(RVA = "0x322DC60", Offset = "0x322C860", VA = "0x18322DC60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001360 RID: 4960
		// (get) Token: 0x0600A776 RID: 42870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001360")]
		private ILODHolder lodHolder
		{
			[Token(Token = "0x600A776")]
			[Address(RVA = "0x322DF70", Offset = "0x322CB70", VA = "0x18322DF70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001361 RID: 4961
		// (get) Token: 0x0600A777 RID: 42871 RVA: 0x00040D28 File Offset: 0x0003EF28
		// (set) Token: 0x0600A778 RID: 42872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001361")]
		public int faceSign
		{
			[Token(Token = "0x600A777")]
			[Address(RVA = "0x322D900", Offset = "0x322C500", VA = "0x18322D900")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600A778")]
			[Address(RVA = "0x322E830", Offset = "0x322D430", VA = "0x18322E830")]
			set
			{
			}
		}

		// Token: 0x17001362 RID: 4962
		// (get) Token: 0x0600A779 RID: 42873 RVA: 0x00040D40 File Offset: 0x0003EF40
		[Token(Token = "0x17001362")]
		public override Vector3 worldCenter
		{
			[Token(Token = "0x600A779")]
			[Address(RVA = "0x322E580", Offset = "0x322D180", VA = "0x18322E580", Slot = "11")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17001363 RID: 4963
		// (get) Token: 0x0600A77A RID: 42874 RVA: 0x00040D58 File Offset: 0x0003EF58
		// (set) Token: 0x0600A77B RID: 42875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001363")]
		public BuildingCharModel charModel
		{
			[Token(Token = "0x600A77A")]
			[Address(RVA = "0x322D800", Offset = "0x322C400", VA = "0x18322D800")]
			[CompilerGenerated]
			get
			{
				return default(BuildingCharModel);
			}
			[Token(Token = "0x600A77B")]
			[Address(RVA = "0x322E700", Offset = "0x322D300", VA = "0x18322E700")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17001364 RID: 4964
		// (get) Token: 0x0600A77C RID: 42876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001364")]
		public VCharacter.Options options
		{
			[Token(Token = "0x600A77C")]
			[Address(RVA = "0x322E140", Offset = "0x322CD40", VA = "0x18322E140")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001365 RID: 4965
		// (get) Token: 0x0600A77D RID: 42877 RVA: 0x00040D70 File Offset: 0x0003EF70
		[Token(Token = "0x17001365")]
		public float moveSpeed
		{
			[Token(Token = "0x600A77D")]
			[Address(RVA = "0x322E060", Offset = "0x322CC60", VA = "0x18322E060", Slot = "22")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17001366 RID: 4966
		// (get) Token: 0x0600A77E RID: 42878 RVA: 0x00040D88 File Offset: 0x0003EF88
		// (set) Token: 0x0600A77F RID: 42879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001366")]
		public float alpha
		{
			[Token(Token = "0x600A77E")]
			[Address(RVA = "0x322D760", Offset = "0x322C360", VA = "0x18322D760")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600A77F")]
			[Address(RVA = "0x322E610", Offset = "0x322D210", VA = "0x18322E610")]
			set
			{
			}
		}

		// Token: 0x17001367 RID: 4967
		// (get) Token: 0x0600A780 RID: 42880 RVA: 0x00040DA0 File Offset: 0x0003EFA0
		// (set) Token: 0x0600A781 RID: 42881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001367")]
		[Inspect(InspectorLevel.Debug)]
		[ReadOnly]
		public bool isSleep
		{
			[Token(Token = "0x600A780")]
			[Address(RVA = "0x322DEB0", Offset = "0x322CAB0", VA = "0x18322DEB0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600A781")]
			[Address(RVA = "0x322EA10", Offset = "0x322D610", VA = "0x18322EA10")]
			set
			{
			}
		}

		// Token: 0x17001368 RID: 4968
		// (get) Token: 0x0600A782 RID: 42882 RVA: 0x00040DB8 File Offset: 0x0003EFB8
		[Token(Token = "0x17001368")]
		public bool isSelected
		{
			[Token(Token = "0x600A782")]
			[Address(RVA = "0x322DE50", Offset = "0x322CA50", VA = "0x18322DE50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001369 RID: 4969
		// (get) Token: 0x0600A783 RID: 42883 RVA: 0x00040DD0 File Offset: 0x0003EFD0
		// (set) Token: 0x0600A784 RID: 42884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001369")]
		public bool isStarted
		{
			[Token(Token = "0x600A783")]
			[Address(RVA = "0x322DF10", Offset = "0x322CB10", VA = "0x18322DF10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600A784")]
			[Address(RVA = "0x322EA90", Offset = "0x322D690", VA = "0x18322EA90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600A785 RID: 42885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A785")]
		[Address(RVA = "0x3229710", Offset = "0x3228310", VA = "0x183229710")]
		public void AddListener(VCharacter.IListener listener)
		{
		}

		// Token: 0x0600A786 RID: 42886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A786")]
		[Address(RVA = "0x322B580", Offset = "0x322A180", VA = "0x18322B580")]
		public void RemoveListener(VCharacter.IListener listener)
		{
		}

		// Token: 0x1700136A RID: 4970
		// (get) Token: 0x0600A787 RID: 42887 RVA: 0x00040DE8 File Offset: 0x0003EFE8
		[Token(Token = "0x1700136A")]
		[Inspect(InspectorLevel.Debug)]
		[ReadOnly]
		public bool isMovable
		{
			[Token(Token = "0x600A787")]
			[Address(RVA = "0x322DDB0", Offset = "0x322C9B0", VA = "0x18322DDB0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700136B RID: 4971
		// (get) Token: 0x0600A788 RID: 42888 RVA: 0x00040E00 File Offset: 0x0003F000
		[Token(Token = "0x1700136B")]
		[Inspect(InspectorLevel.Debug)]
		[ReadOnly]
		public bool isInteractable
		{
			[Token(Token = "0x600A788")]
			[Address(RVA = "0x322DD50", Offset = "0x322C950", VA = "0x18322DD50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700136C RID: 4972
		// (get) Token: 0x0600A789 RID: 42889 RVA: 0x00040E18 File Offset: 0x0003F018
		[Token(Token = "0x1700136C")]
		[Inspect(InspectorLevel.Debug)]
		[ReadOnly]
		public bool hasSpecialAnim
		{
			[Token(Token = "0x600A789")]
			[Address(RVA = "0x322D960", Offset = "0x322C560", VA = "0x18322D960")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700136D RID: 4973
		// (get) Token: 0x0600A78A RID: 42890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700136D")]
		[Inspect(InspectorLevel.Debug)]
		[ReadOnly]
		public string stateDebugStr
		{
			[Token(Token = "0x600A78A")]
			[Address(RVA = "0x322E4D0", Offset = "0x322D0D0", VA = "0x18322E4D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700136E RID: 4974
		// (get) Token: 0x0600A78B RID: 42891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700136E")]
		protected SkeletonAnimation skeleton
		{
			[Token(Token = "0x600A78B")]
			[Address(RVA = "0x322E410", Offset = "0x322D010", VA = "0x18322E410")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700136F RID: 4975
		// (get) Token: 0x0600A78C RID: 42892 RVA: 0x00040E30 File Offset: 0x0003F030
		[Token(Token = "0x1700136F")]
		[Inspect]
		public float spineScale
		{
			[Token(Token = "0x600A78C")]
			[Address(RVA = "0x322E470", Offset = "0x322D070", VA = "0x18322E470")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600A78D RID: 42893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A78D")]
		[Address(RVA = "0x322A770", Offset = "0x3229370", VA = "0x18322A770", Slot = "13")]
		public override void OnInit()
		{
		}

		// Token: 0x0600A78E RID: 42894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A78E")]
		[Address(RVA = "0x322A100", Offset = "0x3228D00", VA = "0x18322A100", Slot = "14")]
		public override void OnEnter()
		{
		}

		// Token: 0x0600A78F RID: 42895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A78F")]
		[Address(RVA = "0x322A1B0", Offset = "0x3228DB0", VA = "0x18322A1B0", Slot = "15")]
		public override void OnExit()
		{
		}

		// Token: 0x0600A790 RID: 42896 RVA: 0x00040E48 File Offset: 0x0003F048
		[Token(Token = "0x600A790")]
		[Address(RVA = "0x322AB40", Offset = "0x3229740", VA = "0x18322AB40", Slot = "16")]
		public override bool OnInteract()
		{
			return default(bool);
		}

		// Token: 0x0600A791 RID: 42897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A791")]
		[Address(RVA = "0x322CB30", Offset = "0x322B730", VA = "0x18322CB30")]
		private void _OnInteractFinish(int stateId, int targetStateId)
		{
		}

		// Token: 0x0600A792 RID: 42898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A792")]
		[Address(RVA = "0x322B960", Offset = "0x322A560", VA = "0x18322B960")]
		public void SetInControl(bool enable)
		{
		}

		// Token: 0x0600A793 RID: 42899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A793")]
		[Address(RVA = "0x3229D00", Offset = "0x3228900", VA = "0x183229D00")]
		public void InteractInControl(VFurnitureBridge.InteractSlot slot)
		{
		}

		// Token: 0x0600A794 RID: 42900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A794")]
		[Address(RVA = "0x322BB20", Offset = "0x322A720", VA = "0x18322BB20")]
		public void SpecialInteractInControl()
		{
		}

		// Token: 0x0600A795 RID: 42901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A795")]
		[Address(RVA = "0x3229DB0", Offset = "0x32289B0", VA = "0x183229DB0")]
		public void MoveToNextRoom(VRoom newRoom)
		{
		}

		// Token: 0x0600A796 RID: 42902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A796")]
		[Address(RVA = "0x3229B00", Offset = "0x3228700", VA = "0x183229B00")]
		public void ControlMove(bool isMove)
		{
		}

		// Token: 0x0600A797 RID: 42903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A797")]
		[Address(RVA = "0x3229BC0", Offset = "0x32287C0", VA = "0x183229BC0")]
		public void EnableOutline(bool enable)
		{
		}

		// Token: 0x0600A798 RID: 42904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A798")]
		[Address(RVA = "0x322BDF0", Offset = "0x322A9F0", VA = "0x18322BDF0")]
		public void TriggerInteractState()
		{
		}

		// Token: 0x0600A799 RID: 42905 RVA: 0x00040E60 File Offset: 0x0003F060
		[Token(Token = "0x600A799")]
		[Address(RVA = "0x322BE70", Offset = "0x322AA70", VA = "0x18322BE70")]
		public bool TryGetHeadPosWithOffset(out Vector3 position)
		{
			return default(bool);
		}

		// Token: 0x0600A79A RID: 42906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A79A")]
		[Address(RVA = "0x322A300", Offset = "0x3228F00", VA = "0x18322A300")]
		public void OnFixedUpdate(float deltaTime)
		{
		}

		// Token: 0x0600A79B RID: 42907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A79B")]
		[Address(RVA = "0x322C450", Offset = "0x322B050", VA = "0x18322C450")]
		private void _DoShadowApplyAlphaBySlot()
		{
		}

		// Token: 0x0600A79C RID: 42908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A79C")]
		[Address(RVA = "0x322AFB0", Offset = "0x3229BB0", VA = "0x18322AFB0", Slot = "17")]
		protected override void OnSelect()
		{
		}

		// Token: 0x0600A79D RID: 42909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A79D")]
		[Address(RVA = "0x3229FC0", Offset = "0x3228BC0", VA = "0x183229FC0", Slot = "18")]
		protected override void OnDeselect()
		{
		}

		// Token: 0x0600A79E RID: 42910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A79E")]
		[Address(RVA = "0x322B040", Offset = "0x3229C40", VA = "0x18322B040")]
		protected void OnSleepChanged(bool value)
		{
		}

		// Token: 0x0600A79F RID: 42911 RVA: 0x00040E78 File Offset: 0x0003F078
		[Token(Token = "0x600A79F")]
		[Address(RVA = "0x322B4C0", Offset = "0x322A0C0", VA = "0x18322B4C0")]
		protected bool PlayAnimation(string animKey, bool loop, float animScale = 1f, float crossfade = 0f)
		{
			return default(bool);
		}

		// Token: 0x0600A7A0 RID: 42912 RVA: 0x00040E90 File Offset: 0x0003F090
		[Token(Token = "0x600A7A0")]
		[Address(RVA = "0x322B1E0", Offset = "0x3229DE0", VA = "0x18322B1E0")]
		protected bool PlayAnimation(string animKey, bool loop, float animScale, out float time, float crossfade = 0f)
		{
			return default(bool);
		}

		// Token: 0x0600A7A1 RID: 42913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A7A1")]
		[Address(RVA = "0x322B690", Offset = "0x322A290", VA = "0x18322B690")]
		protected void ResumeAnimation(string animationName, bool loop)
		{
		}

		// Token: 0x0600A7A2 RID: 42914 RVA: 0x00040EA8 File Offset: 0x0003F0A8
		[Token(Token = "0x600A7A2")]
		[Address(RVA = "0x32299F0", Offset = "0x32285F0", VA = "0x1832299F0")]
		public bool ContainsAnimation(string animKey)
		{
			return default(bool);
		}

		// Token: 0x0600A7A3 RID: 42915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A7A3")]
		[Address(RVA = "0x3229C40", Offset = "0x3228840", VA = "0x183229C40")]
		public string GetCurrentAnimation()
		{
			return null;
		}

		// Token: 0x0600A7A4 RID: 42916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A7A4")]
		[Address(RVA = "0x3229990", Offset = "0x3228590", VA = "0x183229990", Slot = "23")]
		protected virtual StateMachine ConstructStateMachine()
		{
			return null;
		}

		// Token: 0x0600A7A5 RID: 42917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A7A5")]
		[Address(RVA = "0x322C720", Offset = "0x322B320", VA = "0x18322C720")]
		private void _InitLocationAndPose()
		{
		}

		// Token: 0x0600A7A6 RID: 42918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A7A6")]
		[Address(RVA = "0x322CD80", Offset = "0x322B980", VA = "0x18322CD80")]
		private void _SetFaceInternal(int faceSign, bool force)
		{
		}

		// Token: 0x0600A7A7 RID: 42919 RVA: 0x00040EC0 File Offset: 0x0003F0C0
		[Token(Token = "0x600A7A7")]
		[Address(RVA = "0x322D320", Offset = "0x322BF20", VA = "0x18322D320")]
		private bool _TryPickRandomStandGrid(out GridPosition pos)
		{
			return default(bool);
		}

		// Token: 0x0600A7A8 RID: 42920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A7A8")]
		[Address(RVA = "0x322D010", Offset = "0x322BC10", VA = "0x18322D010")]
		private void _SetSleepInternal(bool value, bool force)
		{
		}

		// Token: 0x0600A7A9 RID: 42921 RVA: 0x00040ED8 File Offset: 0x0003F0D8
		[Token(Token = "0x600A7A9")]
		[Address(RVA = "0x322C190", Offset = "0x322AD90", VA = "0x18322C190")]
		private bool _CheckStayAwake()
		{
			return default(bool);
		}

		// Token: 0x0600A7AA RID: 42922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A7AA")]
		[Address(RVA = "0x322CCA0", Offset = "0x322B8A0", VA = "0x18322CCA0")]
		private void _ResetHeight(float height = 0f)
		{
		}

		// Token: 0x0600A7AB RID: 42923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A7AB")]
		[Address(RVA = "0x322CF40", Offset = "0x322BB40", VA = "0x18322CF40")]
		private void _SetShadowActive(bool isActive)
		{
		}

		// Token: 0x0600A7AC RID: 42924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A7AC")]
		[Address(RVA = "0x322D220", Offset = "0x322BE20", VA = "0x18322D220")]
		private void _SetSpineAlpha(float alpha)
		{
		}

		// Token: 0x0600A7AD RID: 42925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A7AD")]
		[Address(RVA = "0x322C560", Offset = "0x322B160", VA = "0x18322C560")]
		private void _DoShadowFollowBone()
		{
		}

		// Token: 0x0600A7AE RID: 42926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A7AE")]
		[Address(RVA = "0x322C030", Offset = "0x322AC30", VA = "0x18322C030")]
		protected void UpdateHeadOffset(VFurnitureBridge.InteractSlot interactSlot)
		{
		}

		// Token: 0x0600A7AF RID: 42927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A7AF")]
		[Address(RVA = "0x32297E0", Offset = "0x32283E0", VA = "0x1832297E0")]
		private void Awake()
		{
		}

		// Token: 0x0600A7B0 RID: 42928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A7B0")]
		[Address(RVA = "0x322BC00", Offset = "0x322A800", VA = "0x18322BC00")]
		private void Start()
		{
		}

		// Token: 0x0600A7B1 RID: 42929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A7B1")]
		[Address(RVA = "0x322A090", Offset = "0x3228C90", VA = "0x18322A090")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600A7B2 RID: 42930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A7B2")]
		[Address(RVA = "0x322D4D0", Offset = "0x322C0D0", VA = "0x18322D4D0")]
		public VCharacter()
		{
		}

		// Token: 0x0600A7B4 RID: 42932 RVA: 0x00040EF0 File Offset: 0x0003F0F0
		[Token(Token = "0x600A7B4")]
		[Address(RVA = "0x322C010", Offset = "0x322AC10", VA = "0x18322C010")]
		private bool <>xLuaBaseProxy_OnInteract()
		{
			return default(bool);
		}

		// Token: 0x0600A7B5 RID: 42933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A7B5")]
		[Address(RVA = "0x322C020", Offset = "0x322AC20", VA = "0x18322C020")]
		private void <>xLuaBaseProxy_OnSelect()
		{
		}

		// Token: 0x0600A7B6 RID: 42934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A7B6")]
		[Address(RVA = "0x322C000", Offset = "0x322AC00", VA = "0x18322C000")]
		private void <>xLuaBaseProxy_OnDeselect()
		{
		}

		// Token: 0x04009F91 RID: 40849
		[Token(Token = "0x4009F91")]
		private const string HEAD_ANCHOR_NAME = "HeadAnchor";

		// Token: 0x04009F92 RID: 40850
		[Token(Token = "0x4009F92")]
		private const string SHADOW_OBJ_NAME = "Shadow";

		// Token: 0x04009F93 RID: 40851
		[Token(Token = "0x4009F93")]
		private const float INIT_FADEIN_DURATION = 0.5f;

		// Token: 0x04009F94 RID: 40852
		[Token(Token = "0x4009F94")]
		private const string SIT_ANIM_NAME = "Sit";

		// Token: 0x04009F95 RID: 40853
		[Token(Token = "0x4009F95")]
		private const string SLEEP_ANIM_NAME = "Sleep";

		// Token: 0x04009F96 RID: 40854
		[Token(Token = "0x4009F96")]
		private const float OFFSET_HEAD_Y_SIT = -0.21f;

		// Token: 0x04009F97 RID: 40855
		[Token(Token = "0x4009F97")]
		private const float OFFSET_HEAD_Y_SLEEP = -0.24f;

		// Token: 0x04009F98 RID: 40856
		[Token(Token = "0x4009F98")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _centerTransform;

		// Token: 0x04009F99 RID: 40857
		[Token(Token = "0x4009F99")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Shadow")]
		private Transform _shadowTransform;

		// Token: 0x04009F9A RID: 40858
		[Token(Token = "0x4009F9A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Shadow")]
		private bool _isShadowFollowBone;

		// Token: 0x04009F9B RID: 40859
		[Token(Token = "0x4009F9B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Shadow")]
		[SpineBone("", "_skeleton", true, false)]
		private string _followBoneName;

		// Token: 0x04009F9C RID: 40860
		[Token(Token = "0x4009F9C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Shadow")]
		private bool _isShadowFollowSlotAlpha;

		// Token: 0x04009F9D RID: 40861
		[Token(Token = "0x4009F9D")]
		[FieldOffset(Offset = "0x58")]
		[SpineSlot("", "_skeleton", false, true, false)]
		[SerializeField]
		[Group("Shadow")]
		private string _followSlotName;

		// Token: 0x04009F9E RID: 40862
		[Token(Token = "0x4009F9E")]
		[FieldOffset(Offset = "0x60")]
		[Group("Shadow")]
		[Range(0f, 1f)]
		[SerializeField]
		private float _baseMultiAlpha;

		// Token: 0x04009F9F RID: 40863
		[Token(Token = "0x4009F9F")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private SkeletonAnimation _skeleton;

		// Token: 0x04009FA0 RID: 40864
		[Token(Token = "0x4009FA0")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private VCharacter.Options _options;

		// Token: 0x04009FA1 RID: 40865
		[Token(Token = "0x4009FA1")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private float _spineScale;

		// Token: 0x04009FA2 RID: 40866
		[Token(Token = "0x4009FA2")]
		[FieldOffset(Offset = "0x7C")]
		private int m_faceSign;

		// Token: 0x04009FA3 RID: 40867
		[Token(Token = "0x4009FA3")]
		[FieldOffset(Offset = "0x80")]
		private StateMachine m_stateMachine;

		// Token: 0x04009FA4 RID: 40868
		[Token(Token = "0x4009FA4")]
		[FieldOffset(Offset = "0x88")]
		private VMoveController m_moveController;

		// Token: 0x04009FA5 RID: 40869
		[Token(Token = "0x4009FA5")]
		[FieldOffset(Offset = "0x90")]
		private SpineOutline m_outline;

		// Token: 0x04009FA6 RID: 40870
		[Token(Token = "0x4009FA6")]
		[FieldOffset(Offset = "0x98")]
		private Transform m_headAnchor;

		// Token: 0x04009FA7 RID: 40871
		[Token(Token = "0x4009FA7")]
		[FieldOffset(Offset = "0xA0")]
		private List<VCharacter.IListener> m_listeners;

		// Token: 0x04009FA8 RID: 40872
		[Token(Token = "0x4009FA8")]
		[FieldOffset(Offset = "0xA8")]
		private Tween m_startTween;

		// Token: 0x04009FA9 RID: 40873
		[Token(Token = "0x4009FA9")]
		[FieldOffset(Offset = "0xB0")]
		private VFurnitureBridge.InteractSlot m_interactingSlot;

		// Token: 0x04009FAA RID: 40874
		[Token(Token = "0x4009FAA")]
		[FieldOffset(Offset = "0xB8")]
		private Vector3 m_headOffset;

		// Token: 0x04009FAB RID: 40875
		[Token(Token = "0x4009FAB")]
		[FieldOffset(Offset = "0xC4")]
		private bool m_isSleep;

		// Token: 0x04009FAC RID: 40876
		[Token(Token = "0x4009FAC")]
		[FieldOffset(Offset = "0xC5")]
		private bool m_isMovable;

		// Token: 0x04009FAD RID: 40877
		[Token(Token = "0x4009FAD")]
		[FieldOffset(Offset = "0xC6")]
		private bool m_isInteractable;

		// Token: 0x04009FAE RID: 40878
		[Token(Token = "0x4009FAE")]
		[FieldOffset(Offset = "0xC7")]
		private bool m_hasSpecialAnim;

		// Token: 0x04009FAF RID: 40879
		[Token(Token = "0x4009FAF")]
		[FieldOffset(Offset = "0xC8")]
		private bool m_isSelected;

		// Token: 0x04009FB0 RID: 40880
		[Token(Token = "0x4009FB0")]
		[FieldOffset(Offset = "0xC9")]
		private bool m_hideOutline;

		// Token: 0x04009FB1 RID: 40881
		[Token(Token = "0x4009FB1")]
		[FieldOffset(Offset = "0xD0")]
		private Bone m_shadowFollowBone;

		// Token: 0x04009FB2 RID: 40882
		[Token(Token = "0x4009FB2")]
		[FieldOffset(Offset = "0xD8")]
		private Slot m_shadowAlphaSourceSlot;

		// Token: 0x04009FB3 RID: 40883
		[Token(Token = "0x4009FB3")]
		[FieldOffset(Offset = "0xE0")]
		private SpriteRenderer m_shadowRenderer;

		// Token: 0x04009FB6 RID: 40886
		[Token(Token = "0x4009FB6")]
		[FieldOffset(Offset = "0xF8")]
		private ILODHolder m_lodHolder;

		// Token: 0x04009FB9 RID: 40889
		[Token(Token = "0x4009FB9")]
		[FieldOffset(Offset = "0x180")]
		private ExclusiveCoroutineHost m_stateTransCoroHost;

		// Token: 0x04009FBA RID: 40890
		[Token(Token = "0x4009FBA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_shadowFollowBone;

		// Token: 0x04009FBB RID: 40891
		[Token(Token = "0x4009FBB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_shadowAlphaSourceSlot;

		// Token: 0x04009FBC RID: 40892
		[Token(Token = "0x4009FBC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_shadowRenderer;

		// Token: 0x04009FBD RID: 40893
		[Token(Token = "0x4009FBD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_inControl;

		// Token: 0x04009FBE RID: 40894
		[Token(Token = "0x4009FBE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_inControl;

		// Token: 0x04009FBF RID: 40895
		[Token(Token = "0x4009FBF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_interactingSlot;

		// Token: 0x04009FC0 RID: 40896
		[Token(Token = "0x4009FC0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_interactingSlot;

		// Token: 0x04009FC1 RID: 40897
		[Token(Token = "0x4009FC1")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_interactingSlotValid;

		// Token: 0x04009FC2 RID: 40898
		[Token(Token = "0x4009FC2")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_moveController;

		// Token: 0x04009FC3 RID: 40899
		[Token(Token = "0x4009FC3")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_hideOutline;

		// Token: 0x04009FC4 RID: 40900
		[Token(Token = "0x4009FC4")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_set_hideOutline;

		// Token: 0x04009FC5 RID: 40901
		[Token(Token = "0x4009FC5")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_isInCFurnitureState;

		// Token: 0x04009FC6 RID: 40902
		[Token(Token = "0x4009FC6")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_isInCSpecialState;

		// Token: 0x04009FC7 RID: 40903
		[Token(Token = "0x4009FC7")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_isInCNormalState;

		// Token: 0x04009FC8 RID: 40904
		[Token(Token = "0x4009FC8")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_lodHolder;

		// Token: 0x04009FC9 RID: 40905
		[Token(Token = "0x4009FC9")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_faceSign;

		// Token: 0x04009FCA RID: 40906
		[Token(Token = "0x4009FCA")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_set_faceSign;

		// Token: 0x04009FCB RID: 40907
		[Token(Token = "0x4009FCB")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_worldCenter;

		// Token: 0x04009FCC RID: 40908
		[Token(Token = "0x4009FCC")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_charModel;

		// Token: 0x04009FCD RID: 40909
		[Token(Token = "0x4009FCD")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_set_charModel;

		// Token: 0x04009FCE RID: 40910
		[Token(Token = "0x4009FCE")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_get_options;

		// Token: 0x04009FCF RID: 40911
		[Token(Token = "0x4009FCF")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_get_moveSpeed;

		// Token: 0x04009FD0 RID: 40912
		[Token(Token = "0x4009FD0")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_get_alpha;

		// Token: 0x04009FD1 RID: 40913
		[Token(Token = "0x4009FD1")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_set_alpha;

		// Token: 0x04009FD2 RID: 40914
		[Token(Token = "0x4009FD2")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_get_isSleep;

		// Token: 0x04009FD3 RID: 40915
		[Token(Token = "0x4009FD3")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_set_isSleep;

		// Token: 0x04009FD4 RID: 40916
		[Token(Token = "0x4009FD4")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_get_isSelected;

		// Token: 0x04009FD5 RID: 40917
		[Token(Token = "0x4009FD5")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_get_isStarted;

		// Token: 0x04009FD6 RID: 40918
		[Token(Token = "0x4009FD6")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_set_isStarted;

		// Token: 0x04009FD7 RID: 40919
		[Token(Token = "0x4009FD7")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_AddListener;

		// Token: 0x04009FD8 RID: 40920
		[Token(Token = "0x4009FD8")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_RemoveListener;

		// Token: 0x04009FD9 RID: 40921
		[Token(Token = "0x4009FD9")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_get_isMovable;

		// Token: 0x04009FDA RID: 40922
		[Token(Token = "0x4009FDA")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_get_isInteractable;

		// Token: 0x04009FDB RID: 40923
		[Token(Token = "0x4009FDB")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_get_hasSpecialAnim;

		// Token: 0x04009FDC RID: 40924
		[Token(Token = "0x4009FDC")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_get_stateDebugStr;

		// Token: 0x04009FDD RID: 40925
		[Token(Token = "0x4009FDD")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_get_skeleton;

		// Token: 0x04009FDE RID: 40926
		[Token(Token = "0x4009FDE")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_get_spineScale;

		// Token: 0x04009FDF RID: 40927
		[Token(Token = "0x4009FDF")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04009FE0 RID: 40928
		[Token(Token = "0x4009FE0")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04009FE1 RID: 40929
		[Token(Token = "0x4009FE1")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x04009FE2 RID: 40930
		[Token(Token = "0x4009FE2")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_OnInteract;

		// Token: 0x04009FE3 RID: 40931
		[Token(Token = "0x4009FE3")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0__OnInteractFinish;

		// Token: 0x04009FE4 RID: 40932
		[Token(Token = "0x4009FE4")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_SetInControl;

		// Token: 0x04009FE5 RID: 40933
		[Token(Token = "0x4009FE5")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_InteractInControl;

		// Token: 0x04009FE6 RID: 40934
		[Token(Token = "0x4009FE6")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_SpecialInteractInControl;

		// Token: 0x04009FE7 RID: 40935
		[Token(Token = "0x4009FE7")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_MoveToNextRoom;

		// Token: 0x04009FE8 RID: 40936
		[Token(Token = "0x4009FE8")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0_ControlMove;

		// Token: 0x04009FE9 RID: 40937
		[Token(Token = "0x4009FE9")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0_EnableOutline;

		// Token: 0x04009FEA RID: 40938
		[Token(Token = "0x4009FEA")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0_TriggerInteractState;

		// Token: 0x04009FEB RID: 40939
		[Token(Token = "0x4009FEB")]
		[FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0_TryGetHeadPosWithOffset;

		// Token: 0x04009FEC RID: 40940
		[Token(Token = "0x4009FEC")]
		[FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0_OnFixedUpdate;

		// Token: 0x04009FED RID: 40941
		[Token(Token = "0x4009FED")]
		[FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0__DoShadowApplyAlphaBySlot;

		// Token: 0x04009FEE RID: 40942
		[Token(Token = "0x4009FEE")]
		[FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0_OnSelect;

		// Token: 0x04009FEF RID: 40943
		[Token(Token = "0x4009FEF")]
		[FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0_OnDeselect;

		// Token: 0x04009FF0 RID: 40944
		[Token(Token = "0x4009FF0")]
		[FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0_OnSleepChanged;

		// Token: 0x04009FF1 RID: 40945
		[Token(Token = "0x4009FF1")]
		[FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0_PlayAnimation;

		// Token: 0x04009FF2 RID: 40946
		[Token(Token = "0x4009FF2")]
		[FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix1_PlayAnimation;

		// Token: 0x04009FF3 RID: 40947
		[Token(Token = "0x4009FF3")]
		[FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0_ResumeAnimation;

		// Token: 0x04009FF4 RID: 40948
		[Token(Token = "0x4009FF4")]
		[FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0_ContainsAnimation;

		// Token: 0x04009FF5 RID: 40949
		[Token(Token = "0x4009FF5")]
		[FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0_GetCurrentAnimation;

		// Token: 0x04009FF6 RID: 40950
		[Token(Token = "0x4009FF6")]
		[FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge __Hotfix0_ConstructStateMachine;

		// Token: 0x04009FF7 RID: 40951
		[Token(Token = "0x4009FF7")]
		[FieldOffset(Offset = "0x1E8")]
		private static DelegateBridge __Hotfix0__InitLocationAndPose;

		// Token: 0x04009FF8 RID: 40952
		[Token(Token = "0x4009FF8")]
		[FieldOffset(Offset = "0x1F0")]
		private static DelegateBridge __Hotfix0__SetFaceInternal;

		// Token: 0x04009FF9 RID: 40953
		[Token(Token = "0x4009FF9")]
		[FieldOffset(Offset = "0x1F8")]
		private static DelegateBridge __Hotfix0__TryPickRandomStandGrid;

		// Token: 0x04009FFA RID: 40954
		[Token(Token = "0x4009FFA")]
		[FieldOffset(Offset = "0x200")]
		private static DelegateBridge __Hotfix0__SetSleepInternal;

		// Token: 0x04009FFB RID: 40955
		[Token(Token = "0x4009FFB")]
		[FieldOffset(Offset = "0x208")]
		private static DelegateBridge __Hotfix0__CheckStayAwake;

		// Token: 0x04009FFC RID: 40956
		[Token(Token = "0x4009FFC")]
		[FieldOffset(Offset = "0x210")]
		private static DelegateBridge __Hotfix0__ResetHeight;

		// Token: 0x04009FFD RID: 40957
		[Token(Token = "0x4009FFD")]
		[FieldOffset(Offset = "0x218")]
		private static DelegateBridge __Hotfix0__SetShadowActive;

		// Token: 0x04009FFE RID: 40958
		[Token(Token = "0x4009FFE")]
		[FieldOffset(Offset = "0x220")]
		private static DelegateBridge __Hotfix0__SetSpineAlpha;

		// Token: 0x04009FFF RID: 40959
		[Token(Token = "0x4009FFF")]
		[FieldOffset(Offset = "0x228")]
		private static DelegateBridge __Hotfix0__DoShadowFollowBone;

		// Token: 0x0400A000 RID: 40960
		[Token(Token = "0x400A000")]
		[FieldOffset(Offset = "0x230")]
		private static DelegateBridge __Hotfix0_UpdateHeadOffset;

		// Token: 0x0400A001 RID: 40961
		[Token(Token = "0x400A001")]
		[FieldOffset(Offset = "0x238")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x0400A002 RID: 40962
		[Token(Token = "0x400A002")]
		[FieldOffset(Offset = "0x240")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0400A003 RID: 40963
		[Token(Token = "0x400A003")]
		[FieldOffset(Offset = "0x248")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0400A004 RID: 40964
		[Token(Token = "0x400A004")]
		[FieldOffset(Offset = "0x250")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001A17 RID: 6679
		[Token(Token = "0x2001A17")]
		[Serializable]
		public class Options : StateMachine.DefaultBlackboard
		{
			// Token: 0x0600A7B7 RID: 42935 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A7B7")]
			[Address(RVA = "0x3225640", Offset = "0x3224240", VA = "0x183225640", Slot = "7")]
			public override void OnReset()
			{
			}

			// Token: 0x0600A7B8 RID: 42936 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A7B8")]
			[Address(RVA = "0x3225670", Offset = "0x3224270", VA = "0x183225670")]
			public Options()
			{
			}

			// Token: 0x0400A005 RID: 40965
			[Token(Token = "0x400A005")]
			[FieldOffset(Offset = "0x10")]
			public Vector2 idleTimeRange;

			// Token: 0x0400A006 RID: 40966
			[Token(Token = "0x400A006")]
			[FieldOffset(Offset = "0x18")]
			public float moveSpeed;

			// Token: 0x0400A007 RID: 40967
			[Token(Token = "0x400A007")]
			[FieldOffset(Offset = "0x1C")]
			public float moveAnimScale;

			// Token: 0x0400A008 RID: 40968
			[Token(Token = "0x400A008")]
			[FieldOffset(Offset = "0x20")]
			public float probToInteractFurniture;

			// Token: 0x0400A009 RID: 40969
			[Token(Token = "0x400A009")]
			[FieldOffset(Offset = "0x28")]
			public VFurnitureBridge.InteractSlot interactSlot;

			// Token: 0x0400A00A RID: 40970
			[Token(Token = "0x400A00A")]
			[FieldOffset(Offset = "0x30")]
			public float probToPlaySpecialAnim;
		}

		// Token: 0x02001A18 RID: 6680
		[Token(Token = "0x2001A18")]
		public interface IListener
		{
			// Token: 0x0600A7B9 RID: 42937
			[Token(Token = "0x600A7B9")]
			bool OnInteract(VCharacter character);

			// Token: 0x0600A7BA RID: 42938
			[Token(Token = "0x600A7BA")]
			void OnSleepChanged(bool isSleep);
		}

		// Token: 0x02001A19 RID: 6681
		[Token(Token = "0x2001A19")]
		public static class States
		{
			// Token: 0x0600A7BB RID: 42939 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600A7BB")]
			[Address(RVA = "0x32256B0", Offset = "0x32242B0", VA = "0x1832256B0")]
			public static StateMachine ConstructStateMachine(VCharacter owner)
			{
				return null;
			}

			// Token: 0x02001A1A RID: 6682
			[Token(Token = "0x2001A1A")]
			public enum State
			{
				// Token: 0x0400A00C RID: 40972
				[Token(Token = "0x400A00C")]
				DEFAULT,
				// Token: 0x0400A00D RID: 40973
				[Token(Token = "0x400A00D")]
				IDLE,
				// Token: 0x0400A00E RID: 40974
				[Token(Token = "0x400A00E")]
				MOVE,
				// Token: 0x0400A00F RID: 40975
				[Token(Token = "0x400A00F")]
				INTERACT,
				// Token: 0x0400A010 RID: 40976
				[Token(Token = "0x400A010")]
				SLEEP,
				// Token: 0x0400A011 RID: 40977
				[Token(Token = "0x400A011")]
				FURNITURE,
				// Token: 0x0400A012 RID: 40978
				[Token(Token = "0x400A012")]
				SPECIAL,
				// Token: 0x0400A013 RID: 40979
				[Token(Token = "0x400A013")]
				C_MOVE,
				// Token: 0x0400A014 RID: 40980
				[Token(Token = "0x400A014")]
				C_IDLE,
				// Token: 0x0400A015 RID: 40981
				[Token(Token = "0x400A015")]
				C_FURNITURE,
				// Token: 0x0400A016 RID: 40982
				[Token(Token = "0x400A016")]
				C_SPECIAL,
				// Token: 0x0400A017 RID: 40983
				[Token(Token = "0x400A017")]
				TERMINAL = -1
			}

			// Token: 0x02001A1B RID: 6683
			[Token(Token = "0x2001A1B")]
			private class CIdleState : HierachyStateMachine<VCharacter.States.State, VCharacter, VCharacter.Options>.StateNode
			{
				// Token: 0x0600A7BC RID: 42940 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600A7BC")]
				[Address(RVA = "0x3219400", Offset = "0x3218000", VA = "0x183219400", Slot = "10")]
				public override void OnEnter(int lastState)
				{
				}

				// Token: 0x0600A7BD RID: 42941 RVA: 0x00040F08 File Offset: 0x0003F108
				[Token(Token = "0x600A7BD")]
				[Address(RVA = "0x3219380", Offset = "0x3217F80", VA = "0x183219380", Slot = "13")]
				public override bool CheckSwitchOut(int nextState)
				{
					return default(bool);
				}

				// Token: 0x0600A7BE RID: 42942 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600A7BE")]
				[Address(RVA = "0x32195B0", Offset = "0x32181B0", VA = "0x1832195B0")]
				public CIdleState()
				{
				}
			}

			// Token: 0x02001A1C RID: 6684
			[Token(Token = "0x2001A1C")]
			private class CMoveState : HierachyStateMachine<VCharacter.States.State, VCharacter, VCharacter.Options>.StateNode
			{
				// Token: 0x0600A7BF RID: 42943 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600A7BF")]
				[Address(RVA = "0x3219670", Offset = "0x3218270", VA = "0x183219670", Slot = "10")]
				public override void OnEnter(int lastState)
				{
				}

				// Token: 0x0600A7C0 RID: 42944 RVA: 0x00040F20 File Offset: 0x0003F120
				[Token(Token = "0x600A7C0")]
				[Address(RVA = "0x32195F0", Offset = "0x32181F0", VA = "0x1832195F0", Slot = "13")]
				public override bool CheckSwitchOut(int nextState)
				{
					return default(bool);
				}

				// Token: 0x0600A7C1 RID: 42945 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600A7C1")]
				[Address(RVA = "0x3219780", Offset = "0x3218380", VA = "0x183219780")]
				public CMoveState()
				{
				}
			}

			// Token: 0x02001A1D RID: 6685
			[Token(Token = "0x2001A1D")]
			private class CFurnitureState : HierachyStateMachine<VCharacter.States.State, VCharacter, VCharacter.Options>.SubStateMachineNode<VCharacter.States.CFurnitureState.SubState>
			{
				// Token: 0x0600A7C2 RID: 42946 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600A7C2")]
				[Address(RVA = "0x3218F80", Offset = "0x3217B80", VA = "0x183218F80", Slot = "14")]
				protected override void ExitByDefault()
				{
				}

				// Token: 0x0600A7C3 RID: 42947 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600A7C3")]
				[Address(RVA = "0x3218FC0", Offset = "0x3217BC0", VA = "0x183218FC0", Slot = "15")]
				protected override void InitStateMachine(HierachyStateMachine<VCharacter.States.State, VCharacter, VCharacter.Options>.SubStateMachine<VCharacter.States.CFurnitureState.SubState> stateMachine)
				{
				}

				// Token: 0x0600A7C4 RID: 42948 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600A7C4")]
				[Address(RVA = "0x32190D0", Offset = "0x3217CD0", VA = "0x1832190D0", Slot = "10")]
				public override void OnEnter(int lastState)
				{
				}

				// Token: 0x0600A7C5 RID: 42949 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600A7C5")]
				[Address(RVA = "0x3219240", Offset = "0x3217E40", VA = "0x183219240", Slot = "11")]
				public override void OnExit(int newState)
				{
				}

				// Token: 0x0600A7C6 RID: 42950 RVA: 0x00040F38 File Offset: 0x0003F138
				[Token(Token = "0x600A7C6")]
				[Address(RVA = "0x3218EB0", Offset = "0x3217AB0", VA = "0x183218EB0", Slot = "13")]
				public override bool CheckSwitchOut(int nextState)
				{
					return default(bool);
				}

				// Token: 0x0600A7C7 RID: 42951 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600A7C7")]
				[Address(RVA = "0x3219340", Offset = "0x3217F40", VA = "0x183219340")]
				public CFurnitureState()
				{
				}

				// Token: 0x02001A1E RID: 6686
				[Token(Token = "0x2001A1E")]
				public enum SubState
				{
					// Token: 0x0400A019 RID: 40985
					[Token(Token = "0x400A019")]
					DEFAULT = 8,
					// Token: 0x0400A01A RID: 40986
					[Token(Token = "0x400A01A")]
					MOVE,
					// Token: 0x0400A01B RID: 40987
					[Token(Token = "0x400A01B")]
					INTERACT,
					// Token: 0x0400A01C RID: 40988
					[Token(Token = "0x400A01C")]
					TERMINAL = 8
				}

				// Token: 0x02001A1F RID: 6687
				[Token(Token = "0x2001A1F")]
				private class MoveState : HierachyStateMachine<VCharacter.States.State, VCharacter, VCharacter.Options>.SubStateMachineNode<VCharacter.States.CFurnitureState.SubState>.SubStateNode
				{
					// Token: 0x0600A7C8 RID: 42952 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x600A7C8")]
					[Address(RVA = "0x32255F0", Offset = "0x32241F0", VA = "0x1832255F0")]
					public MoveState(VCharacter.States.CFurnitureState parentState)
					{
					}

					// Token: 0x0600A7C9 RID: 42953 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x600A7C9")]
					[Address(RVA = "0x3224E60", Offset = "0x3223A60", VA = "0x183224E60", Slot = "10")]
					public override void OnEnter(int lastState)
					{
					}

					// Token: 0x0600A7CA RID: 42954 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x600A7CA")]
					[Address(RVA = "0x3225390", Offset = "0x3223F90", VA = "0x183225390", Slot = "12")]
					public override void OnTick(FP deltaTimeFp)
					{
					}

					// Token: 0x0600A7CB RID: 42955 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x600A7CB")]
					[Address(RVA = "0x3225310", Offset = "0x3223F10", VA = "0x183225310", Slot = "11")]
					public override void OnExit(int newState)
					{
					}
				}

				// Token: 0x02001A20 RID: 6688
				[Token(Token = "0x2001A20")]
				private class InteractState : HierachyStateMachine<VCharacter.States.State, VCharacter, VCharacter.Options>.SubStateMachineNode<VCharacter.States.CFurnitureState.SubState>.SubStateNode
				{
					// Token: 0x0600A7CD RID: 42957 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x600A7CD")]
					[Address(RVA = "0x3234CF0", Offset = "0x32338F0", VA = "0x183234CF0")]
					public InteractState(VCharacter.States.CFurnitureState parentState)
					{
					}

					// Token: 0x0600A7CE RID: 42958 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x600A7CE")]
					[Address(RVA = "0x3233C90", Offset = "0x3232890", VA = "0x183233C90", Slot = "10")]
					public override void OnEnter(int lastState)
					{
					}

					// Token: 0x0600A7CF RID: 42959 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x600A7CF")]
					[Address(RVA = "0x3234010", Offset = "0x3232C10", VA = "0x183234010", Slot = "11")]
					public override void OnExit(int newState)
					{
					}

					// Token: 0x0600A7D0 RID: 42960 RVA: 0x00002050 File Offset: 0x00000250
					[Token(Token = "0x600A7D0")]
					[Address(RVA = "0x32347B0", Offset = "0x32333B0", VA = "0x1832347B0")]
					private IEnumerator _DoInteract(VFurnitureBridge.InteractSlot slot, int faceSign, bool useFade)
					{
						return null;
					}

					// Token: 0x0600A7D1 RID: 42961 RVA: 0x00002050 File Offset: 0x00000250
					[Token(Token = "0x600A7D1")]
					[Address(RVA = "0x3234650", Offset = "0x3233250", VA = "0x183234650")]
					private IEnumerator _DoFadeTween(Vector3 targetPos, int faceSign, string animKey)
					{
						return null;
					}

					// Token: 0x0600A7D2 RID: 42962 RVA: 0x00002050 File Offset: 0x00000250
					[Token(Token = "0x600A7D2")]
					[Address(RVA = "0x3234910", Offset = "0x3233510", VA = "0x183234910")]
					private IEnumerator _DoMoveTween(Vector3 targetPos, int faceSign, string animKey, float duration)
					{
						return null;
					}

					// Token: 0x0400A01D RID: 40989
					[Token(Token = "0x400A01D")]
					[FieldOffset(Offset = "0x20")]
					private Tween m_tween;

					// Token: 0x0400A01E RID: 40990
					[Token(Token = "0x400A01E")]
					[FieldOffset(Offset = "0x28")]
					private Vector2 m_startPos;
				}
			}

			// Token: 0x02001A27 RID: 6695
			[Token(Token = "0x2001A27")]
			private class CSpecialState : HierachyStateMachine<VCharacter.States.State, VCharacter, VCharacter.Options>.StateNode
			{
				// Token: 0x0600A7EF RID: 42991 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600A7EF")]
				[Address(RVA = "0x3231370", Offset = "0x322FF70", VA = "0x183231370", Slot = "10")]
				public override void OnEnter(int lastState)
				{
				}

				// Token: 0x0600A7F0 RID: 42992 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600A7F0")]
				[Address(RVA = "0x3231720", Offset = "0x3230320", VA = "0x183231720", Slot = "12")]
				public override void OnTick(FP deltaTimeFp)
				{
				}

				// Token: 0x0600A7F1 RID: 42993 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600A7F1")]
				[Address(RVA = "0x32317D0", Offset = "0x32303D0", VA = "0x1832317D0")]
				public CSpecialState()
				{
				}

				// Token: 0x0400A03E RID: 41022
				[Token(Token = "0x400A03E")]
				[FieldOffset(Offset = "0x18")]
				private float m_waitTime;
			}

			// Token: 0x02001A28 RID: 6696
			[Token(Token = "0x2001A28")]
			private class IdleState : HierachyStateMachine<VCharacter.States.State, VCharacter, VCharacter.Options>.StateNode
			{
				// Token: 0x0600A7F2 RID: 42994 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600A7F2")]
				[Address(RVA = "0x3231B80", Offset = "0x3230780", VA = "0x183231B80", Slot = "10")]
				public override void OnEnter(int lastState)
				{
				}

				// Token: 0x0600A7F3 RID: 42995 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600A7F3")]
				[Address(RVA = "0x3231CE0", Offset = "0x32308E0", VA = "0x183231CE0", Slot = "12")]
				public override void OnTick(FP deltaTimeFp)
				{
				}

				// Token: 0x0600A7F4 RID: 42996 RVA: 0x00041010 File Offset: 0x0003F210
				[Token(Token = "0x600A7F4")]
				[Address(RVA = "0x3232280", Offset = "0x3230E80", VA = "0x183232280")]
				private bool _TryToSwitchOutFromIdle(float deltaTime)
				{
					return default(bool);
				}

				// Token: 0x0600A7F5 RID: 42997 RVA: 0x00041028 File Offset: 0x0003F228
				[Token(Token = "0x600A7F5")]
				[Address(RVA = "0x3231E20", Offset = "0x3230A20", VA = "0x183231E20")]
				private bool _CheckToInteractFurniture()
				{
					return default(bool);
				}

				// Token: 0x0600A7F6 RID: 42998 RVA: 0x00041040 File Offset: 0x0003F240
				[Token(Token = "0x600A7F6")]
				[Address(RVA = "0x3232100", Offset = "0x3230D00", VA = "0x183232100")]
				private bool _CheckToPlaySpecialAnim()
				{
					return default(bool);
				}

				// Token: 0x0600A7F7 RID: 42999 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600A7F7")]
				[Address(RVA = "0x3232480", Offset = "0x3231080", VA = "0x183232480")]
				public IdleState()
				{
				}

				// Token: 0x0400A03F RID: 41023
				[Token(Token = "0x400A03F")]
				[FieldOffset(Offset = "0x18")]
				private float m_remainingTime;
			}

			// Token: 0x02001A29 RID: 6697
			[Token(Token = "0x2001A29")]
			private class SpecialState : HierachyStateMachine<VCharacter.States.State, VCharacter, VCharacter.Options>.StateNode
			{
				// Token: 0x0600A7F8 RID: 43000 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600A7F8")]
				[Address(RVA = "0x3237320", Offset = "0x3235F20", VA = "0x183237320", Slot = "10")]
				public override void OnEnter(int lastState)
				{
				}

				// Token: 0x0600A7F9 RID: 43001 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600A7F9")]
				[Address(RVA = "0x3237420", Offset = "0x3236020", VA = "0x183237420", Slot = "12")]
				public override void OnTick(FP deltaTimeFp)
				{
				}

				// Token: 0x0600A7FA RID: 43002 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600A7FA")]
				[Address(RVA = "0x32374D0", Offset = "0x32360D0", VA = "0x1832374D0")]
				public SpecialState()
				{
				}

				// Token: 0x0400A040 RID: 41024
				[Token(Token = "0x400A040")]
				[FieldOffset(Offset = "0x18")]
				private float m_waitTime;
			}

			// Token: 0x02001A2A RID: 6698
			[Token(Token = "0x2001A2A")]
			private class MoveState : HierachyStateMachine<VCharacter.States.State, VCharacter, VCharacter.Options>.StateNode
			{
				// Token: 0x0600A7FB RID: 43003 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600A7FB")]
				[Address(RVA = "0x3234D40", Offset = "0x3233940", VA = "0x183234D40", Slot = "10")]
				public override void OnEnter(int lastState)
				{
				}

				// Token: 0x0600A7FC RID: 43004 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600A7FC")]
				[Address(RVA = "0x3235630", Offset = "0x3234230", VA = "0x183235630", Slot = "12")]
				public override void OnTick(FP deltaTimeFp)
				{
				}

				// Token: 0x0600A7FD RID: 43005 RVA: 0x00041058 File Offset: 0x0003F258
				[Token(Token = "0x600A7FD")]
				[Address(RVA = "0x3235AD0", Offset = "0x32346D0", VA = "0x183235AD0")]
				private bool _PickMoveTarget(out GridPosition pos)
				{
					return default(bool);
				}

				// Token: 0x0600A7FE RID: 43006 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600A7FE")]
				[Address(RVA = "0x3235C30", Offset = "0x3234830", VA = "0x183235C30")]
				public MoveState()
				{
				}
			}

			// Token: 0x02001A2C RID: 6700
			[Token(Token = "0x2001A2C")]
			private class InteractState : HierachyStateMachine<VCharacter.States.State, VCharacter, VCharacter.Options>.StateNode
			{
				// Token: 0x0600A802 RID: 43010 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600A802")]
				[Address(RVA = "0x3233B90", Offset = "0x3232790", VA = "0x183233B90", Slot = "10")]
				public override void OnEnter(int lastState)
				{
				}

				// Token: 0x0600A803 RID: 43011 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600A803")]
				[Address(RVA = "0x3234340", Offset = "0x3232F40", VA = "0x183234340", Slot = "12")]
				public override void OnTick(FP deltaTimeFp)
				{
				}

				// Token: 0x0600A804 RID: 43012 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600A804")]
				[Address(RVA = "0x3234CB0", Offset = "0x32338B0", VA = "0x183234CB0")]
				public InteractState()
				{
				}

				// Token: 0x0400A043 RID: 41027
				[Token(Token = "0x400A043")]
				[FieldOffset(Offset = "0x18")]
				private float m_waitTime;
			}

			// Token: 0x02001A2D RID: 6701
			[Token(Token = "0x2001A2D")]
			private class SleepState : HierachyStateMachine<VCharacter.States.State, VCharacter, VCharacter.Options>.StateNode
			{
				// Token: 0x0600A805 RID: 43013 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600A805")]
				[Address(RVA = "0x3236FD0", Offset = "0x3235BD0", VA = "0x183236FD0", Slot = "10")]
				public override void OnEnter(int lastState)
				{
				}

				// Token: 0x0600A806 RID: 43014 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600A806")]
				[Address(RVA = "0x3237200", Offset = "0x3235E00", VA = "0x183237200")]
				private void _FreezeAnimation(SkeletonAnimation skeleton, bool forceUpdateBeforeFreeze)
				{
				}

				// Token: 0x0600A807 RID: 43015 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600A807")]
				[Address(RVA = "0x3237170", Offset = "0x3235D70", VA = "0x183237170", Slot = "12")]
				public override void OnTick(FP deltaTimeFp)
				{
				}

				// Token: 0x0600A808 RID: 43016 RVA: 0x00041088 File Offset: 0x0003F288
				[Token(Token = "0x600A808")]
				[Address(RVA = "0x3236F50", Offset = "0x3235B50", VA = "0x183236F50", Slot = "13")]
				public override bool CheckSwitchOut(int nextState)
				{
					return default(bool);
				}

				// Token: 0x0600A809 RID: 43017 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600A809")]
				[Address(RVA = "0x32370F0", Offset = "0x3235CF0", VA = "0x1832370F0", Slot = "11")]
				public override void OnExit(int newState)
				{
				}

				// Token: 0x0600A80A RID: 43018 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600A80A")]
				[Address(RVA = "0x3237290", Offset = "0x3235E90", VA = "0x183237290")]
				public SleepState()
				{
				}

				// Token: 0x0400A044 RID: 41028
				[Token(Token = "0x400A044")]
				[FieldOffset(Offset = "0x18")]
				private bool m_skeletonUpdateNothing;
			}

			// Token: 0x02001A2E RID: 6702
			[Token(Token = "0x2001A2E")]
			private class FurnitureState : HierachyStateMachine<VCharacter.States.State, VCharacter, VCharacter.Options>.SubStateMachineNode<VCharacter.States.FurnitureState.SubState>
			{
				// Token: 0x0600A80B RID: 43019 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600A80B")]
				[Address(RVA = "0x3231980", Offset = "0x3230580", VA = "0x183231980", Slot = "10")]
				public override void OnEnter(int lastState)
				{
				}

				// Token: 0x0600A80C RID: 43020 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600A80C")]
				[Address(RVA = "0x3231A70", Offset = "0x3230670", VA = "0x183231A70", Slot = "11")]
				public override void OnExit(int newState)
				{
				}

				// Token: 0x0600A80D RID: 43021 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600A80D")]
				[Address(RVA = "0x3231810", Offset = "0x3230410", VA = "0x183231810", Slot = "14")]
				protected override void ExitByDefault()
				{
				}

				// Token: 0x0600A80E RID: 43022 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600A80E")]
				[Address(RVA = "0x3231850", Offset = "0x3230450", VA = "0x183231850", Slot = "15")]
				protected override void InitStateMachine(HierachyStateMachine<VCharacter.States.State, VCharacter, VCharacter.Options>.SubStateMachine<VCharacter.States.FurnitureState.SubState> stateMachine)
				{
				}

				// Token: 0x0600A80F RID: 43023 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600A80F")]
				[Address(RVA = "0x3231B40", Offset = "0x3230740", VA = "0x183231B40")]
				public FurnitureState()
				{
				}

				// Token: 0x02001A2F RID: 6703
				[Token(Token = "0x2001A2F")]
				public enum SubState
				{
					// Token: 0x0400A046 RID: 41030
					[Token(Token = "0x400A046")]
					DEFAULT,
					// Token: 0x0400A047 RID: 41031
					[Token(Token = "0x400A047")]
					MOVE,
					// Token: 0x0400A048 RID: 41032
					[Token(Token = "0x400A048")]
					INTERACT,
					// Token: 0x0400A049 RID: 41033
					[Token(Token = "0x400A049")]
					TERMINAL = -1
				}

				// Token: 0x02001A30 RID: 6704
				[Token(Token = "0x2001A30")]
				private class MoveState : HierachyStateMachine<VCharacter.States.State, VCharacter, VCharacter.Options>.SubStateMachineNode<VCharacter.States.FurnitureState.SubState>.SubStateNode
				{
					// Token: 0x0600A810 RID: 43024 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x600A810")]
					[Address(RVA = "0x3235C70", Offset = "0x3234870", VA = "0x183235C70")]
					public MoveState(VCharacter.States.FurnitureState parentState)
					{
					}

					// Token: 0x0600A811 RID: 43025 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x600A811")]
					[Address(RVA = "0x3235060", Offset = "0x3233C60", VA = "0x183235060", Slot = "10")]
					public override void OnEnter(int lastState)
					{
					}

					// Token: 0x0600A812 RID: 43026 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x600A812")]
					[Address(RVA = "0x32357C0", Offset = "0x32343C0", VA = "0x1832357C0", Slot = "12")]
					public override void OnTick(FP deltaTimeFp)
					{
					}
				}

				// Token: 0x02001A31 RID: 6705
				[Token(Token = "0x2001A31")]
				private class InteractState : HierachyStateMachine<VCharacter.States.State, VCharacter, VCharacter.Options>.SubStateMachineNode<VCharacter.States.FurnitureState.SubState>.SubStateNode
				{
					// Token: 0x0600A814 RID: 43028 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x600A814")]
					[Address(RVA = "0x3234C60", Offset = "0x3233860", VA = "0x183234C60")]
					public InteractState(VCharacter.States.FurnitureState parentState)
					{
					}

					// Token: 0x0600A815 RID: 43029 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x600A815")]
					[Address(RVA = "0x3233890", Offset = "0x3232490", VA = "0x183233890", Slot = "10")]
					public override void OnEnter(int lastState)
					{
					}

					// Token: 0x0600A816 RID: 43030 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x600A816")]
					[Address(RVA = "0x32343F0", Offset = "0x3232FF0", VA = "0x1832343F0", Slot = "12")]
					public override void OnTick(FP deltaTimeFp)
					{
					}

					// Token: 0x0600A817 RID: 43031 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x600A817")]
					[Address(RVA = "0x3234200", Offset = "0x3232E00", VA = "0x183234200", Slot = "11")]
					public override void OnExit(int newState)
					{
					}

					// Token: 0x0600A818 RID: 43032 RVA: 0x00002050 File Offset: 0x00000250
					[Token(Token = "0x600A818")]
					[Address(RVA = "0x3234710", Offset = "0x3233310", VA = "0x183234710")]
					private IEnumerator _DoInteract(VFurnitureBridge.InteractSlot slot, float interactTime)
					{
						return null;
					}

					// Token: 0x0600A819 RID: 43033 RVA: 0x00002050 File Offset: 0x00000250
					[Token(Token = "0x600A819")]
					[Address(RVA = "0x3234870", Offset = "0x3233470", VA = "0x183234870")]
					private IEnumerator _DoMoveTween(Vector3 targetPos, float duration)
					{
						return null;
					}

					// Token: 0x0600A81A RID: 43034 RVA: 0x000410B8 File Offset: 0x0003F2B8
					[Token(Token = "0x600A81A")]
					[Address(RVA = "0x32349E0", Offset = "0x32335E0", VA = "0x1832349E0")]
					private bool _TryGetOneOfStartPos(out Vector2 retPos)
					{
						return default(bool);
					}

					// Token: 0x0600A81B RID: 43035 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x600A81B")]
					[Address(RVA = "0x32345C0", Offset = "0x32331C0", VA = "0x1832345C0")]
					private void _ClearAll()
					{
					}

					// Token: 0x0400A04A RID: 41034
					[Token(Token = "0x400A04A")]
					[FieldOffset(Offset = "0x20")]
					private bool m_isAnimationFinished;

					// Token: 0x0400A04B RID: 41035
					[Token(Token = "0x400A04B")]
					[FieldOffset(Offset = "0x28")]
					private Tween m_tween;

					// Token: 0x0400A04C RID: 41036
					[Token(Token = "0x400A04C")]
					[FieldOffset(Offset = "0x30")]
					private float m_protectTimeToExit;
				}
			}
		}
	}
}
