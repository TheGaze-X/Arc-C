using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x02000076 RID: 118
	[Token(Token = "0x2000076")]
	[DisallowMultipleComponent]
	[AddComponentMenu("UI/Toggle Group", 31)]
	public class ToggleGroup : UIBehaviour
	{
		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000529 RID: 1321 RVA: 0x000040E0 File Offset: 0x000022E0
		// (set) Token: 0x0600052A RID: 1322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000168")]
		public bool allowSwitchOff
		{
			[Token(Token = "0x6000529")]
			[Address(RVA = "0x4F4E70", Offset = "0x4F3A70", VA = "0x1804F4E70")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600052A")]
			[Address(RVA = "0x4F4E80", Offset = "0x4F3A80", VA = "0x1804F4E80")]
			set
			{
			}
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600052B")]
		[Address(RVA = "0x5B800F0", Offset = "0x5B7ECF0", VA = "0x185B800F0")]
		protected ToggleGroup()
		{
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600052C")]
		[Address(RVA = "0x5B7FD60", Offset = "0x5B7E960", VA = "0x185B7FD60", Slot = "6")]
		protected override void Start()
		{
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600052D")]
		[Address(RVA = "0x5B7FD60", Offset = "0x5B7E960", VA = "0x185B7FD60", Slot = "5")]
		protected override void OnEnable()
		{
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600052E")]
		[Address(RVA = "0x5B7FF90", Offset = "0x5B7EB90", VA = "0x185B7FF90")]
		private void ValidateToggleIsInGroup(Toggle toggle)
		{
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600052F")]
		[Address(RVA = "0x5B7FAE0", Offset = "0x5B7E6E0", VA = "0x185B7FAE0")]
		public void NotifyToggleOn(Toggle toggle, bool sendCallback = true)
		{
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000530")]
		[Address(RVA = "0x5B7FF10", Offset = "0x5B7EB10", VA = "0x185B7FF10")]
		public void UnregisterToggle(Toggle toggle)
		{
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000531")]
		[Address(RVA = "0x5B7FD80", Offset = "0x5B7E980", VA = "0x185B7FD80")]
		public void RegisterToggle(Toggle toggle)
		{
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000532")]
		[Address(RVA = "0x5B7F650", Offset = "0x5B7E250", VA = "0x185B7F650")]
		public void EnsureValidState()
		{
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x000040F8 File Offset: 0x000022F8
		[Token(Token = "0x6000533")]
		[Address(RVA = "0x5B7F4F0", Offset = "0x5B7E0F0", VA = "0x185B7F4F0")]
		public bool AnyTogglesOn()
		{
			return default(bool);
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000534")]
		[Address(RVA = "0x5B7F3D0", Offset = "0x5B7DFD0", VA = "0x185B7F3D0")]
		public IEnumerable<Toggle> ActiveToggles()
		{
			return null;
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000535")]
		[Address(RVA = "0x5B7FA70", Offset = "0x5B7E670", VA = "0x185B7FA70")]
		public Toggle GetFirstActiveToggle()
		{
			return null;
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000536")]
		[Address(RVA = "0x5B7FE00", Offset = "0x5B7EA00", VA = "0x185B7FE00")]
		public void SetAllTogglesOff(bool sendCallback = true)
		{
		}

		// Token: 0x04000273 RID: 627
		[Token(Token = "0x4000273")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_AllowSwitchOff;

		// Token: 0x04000274 RID: 628
		[Token(Token = "0x4000274")]
		[FieldOffset(Offset = "0x20")]
		protected List<Toggle> m_Toggles;
	}
}
