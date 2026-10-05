using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.EventSystems
{
	// Token: 0x020000CC RID: 204
	[Token(Token = "0x20000CC")]
	[RequireComponent(typeof(EventSystem))]
	public abstract class BaseInputModule : UIBehaviour
	{
		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000743 RID: 1859 RVA: 0x00004D28 File Offset: 0x00002F28
		// (set) Token: 0x06000744 RID: 1860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001F7")]
		internal bool sendPointerHoverToParent
		{
			[Token(Token = "0x6000743")]
			[Address(RVA = "0x4F1E20", Offset = "0x4F0A20", VA = "0x1804F1E20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000744")]
			[Address(RVA = "0x4F1E30", Offset = "0x4F0A30", VA = "0x1804F1E30")]
			set
			{
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000745 RID: 1861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001F8")]
		public BaseInput input
		{
			[Token(Token = "0x6000745")]
			[Address(RVA = "0x5B83F50", Offset = "0x5B82B50", VA = "0x185B83F50")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000746 RID: 1862 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000747 RID: 1863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001F9")]
		public BaseInput inputOverride
		{
			[Token(Token = "0x6000746")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000747")]
			[Address(RVA = "0x4EEA30", Offset = "0x4ED630", VA = "0x1804EEA30")]
			set
			{
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000748 RID: 1864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001FA")]
		protected EventSystem eventSystem
		{
			[Token(Token = "0x6000748")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000749")]
		[Address(RVA = "0x5B83E20", Offset = "0x5B82A20", VA = "0x185B83E20", Slot = "5")]
		protected override void OnEnable()
		{
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600074A")]
		[Address(RVA = "0x5B83E00", Offset = "0x5B82A00", VA = "0x185B83E00", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x0600074B RID: 1867
		[Token(Token = "0x600074B")]
		public abstract void Process();

		// Token: 0x0600074C RID: 1868 RVA: 0x00004D40 File Offset: 0x00002F40
		[Token(Token = "0x600074C")]
		[Address(RVA = "0x5B82F30", Offset = "0x5B81B30", VA = "0x185B82F30")]
		protected static RaycastResult FindFirstRaycast(List<RaycastResult> candidates)
		{
			return default(RaycastResult);
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x00004D58 File Offset: 0x00002F58
		[Token(Token = "0x600074D")]
		[Address(RVA = "0x5B82D30", Offset = "0x5B81930", VA = "0x185B82D30")]
		protected static MoveDirection DetermineMoveDirection(float x, float y)
		{
			return MoveDirection.Left;
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x00004D70 File Offset: 0x00002F70
		[Token(Token = "0x600074E")]
		[Address(RVA = "0x5B82CB0", Offset = "0x5B818B0", VA = "0x185B82CB0")]
		protected static MoveDirection DetermineMoveDirection(float x, float y, float deadZone)
		{
			return MoveDirection.Left;
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600074F")]
		[Address(RVA = "0x5B82DA0", Offset = "0x5B819A0", VA = "0x185B82DA0")]
		protected static GameObject FindCommonRoot(GameObject g1, GameObject g2)
		{
			return null;
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000750")]
		[Address(RVA = "0x5B832A0", Offset = "0x5B81EA0", VA = "0x185B832A0")]
		protected void HandlePointerExitAndEnter(PointerEventData currentPointerData, GameObject newEnterTarget)
		{
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000751")]
		[Address(RVA = "0x5B83070", Offset = "0x5B81C70", VA = "0x185B83070", Slot = "18")]
		protected virtual AxisEventData GetAxisEventData(float x, float y, float moveDeadZone)
		{
			return null;
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000752")]
		[Address(RVA = "0x5B831E0", Offset = "0x5B81DE0", VA = "0x185B831E0", Slot = "19")]
		protected virtual BaseEventData GetBaseEventData()
		{
			return null;
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x00004D88 File Offset: 0x00002F88
		[Token(Token = "0x6000753")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "20")]
		public virtual bool IsPointerOverGameObject(int pointerId)
		{
			return default(bool);
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000754")]
		[Address(RVA = "0x24EF2B0", Offset = "0x24EDEB0", VA = "0x1824EF2B0", Slot = "21")]
		public virtual void ClearPointerOverGameObject()
		{
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x00004DA0 File Offset: 0x00002FA0
		[Token(Token = "0x6000755")]
		[Address(RVA = "0x5B83E80", Offset = "0x5B82A80", VA = "0x185B83E80", Slot = "22")]
		public virtual bool ShouldActivateModule()
		{
			return default(bool);
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000756")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "23")]
		public virtual void DeactivateModule()
		{
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000757")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "24")]
		public virtual void ActivateModule()
		{
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000758")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "25")]
		public virtual void UpdateModule()
		{
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x00004DB8 File Offset: 0x00002FB8
		[Token(Token = "0x6000759")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "26")]
		public virtual bool IsModuleSupported()
		{
			return default(bool);
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x00004DD0 File Offset: 0x00002FD0
		[Token(Token = "0x600075A")]
		[Address(RVA = "0x5B82C10", Offset = "0x5B81810", VA = "0x185B82C10", Slot = "27")]
		public virtual int ConvertUIToolkitPointerId(PointerEventData sourcePointerData)
		{
			return 0;
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600075B")]
		[Address(RVA = "0x5B83EC0", Offset = "0x5B82AC0", VA = "0x185B83EC0")]
		protected BaseInputModule()
		{
		}

		// Token: 0x0400036D RID: 877
		[Token(Token = "0x400036D")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		protected List<RaycastResult> m_RaycastResultCache;

		// Token: 0x0400036E RID: 878
		[Token(Token = "0x400036E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool m_SendPointerHoverToParent;

		// Token: 0x0400036F RID: 879
		[Token(Token = "0x400036F")]
		[FieldOffset(Offset = "0x28")]
		private AxisEventData m_AxisEventData;

		// Token: 0x04000370 RID: 880
		[Token(Token = "0x4000370")]
		[FieldOffset(Offset = "0x30")]
		private EventSystem m_EventSystem;

		// Token: 0x04000371 RID: 881
		[Token(Token = "0x4000371")]
		[FieldOffset(Offset = "0x38")]
		private BaseEventData m_BaseEventData;

		// Token: 0x04000372 RID: 882
		[Token(Token = "0x4000372")]
		[FieldOffset(Offset = "0x40")]
		protected bool m_ForceUpdatePointInside;

		// Token: 0x04000373 RID: 883
		[Token(Token = "0x4000373")]
		[FieldOffset(Offset = "0x48")]
		protected BaseInput m_InputOverride;

		// Token: 0x04000374 RID: 884
		[Token(Token = "0x4000374")]
		[FieldOffset(Offset = "0x50")]
		private BaseInput m_DefaultInput;
	}
}
