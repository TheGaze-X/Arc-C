using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem
{
	// Token: 0x02000023 RID: 35
	[Token(Token = "0x2000023")]
	[Serializable]
	public sealed class InputActionMap : ICloneable, ISerializationCallbackReceiver, IInputActionCollection2, IInputActionCollection, IEnumerable<InputAction>, IEnumerable, IDisposable
	{
		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060001AA RID: 426 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000B1")]
		public string name
		{
			[Token(Token = "0x60001AA")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060001AB RID: 427 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000B2")]
		public InputActionAsset asset
		{
			[Token(Token = "0x60001AB")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060001AC RID: 428 RVA: 0x000024F0 File Offset: 0x000006F0
		[Token(Token = "0x170000B3")]
		public Guid id
		{
			[Token(Token = "0x60001AC")]
			[Address(RVA = "0x55D36C0", Offset = "0x55D22C0", VA = "0x1855D36C0")]
			get
			{
				return default(Guid);
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060001AD RID: 429 RVA: 0x00002508 File Offset: 0x00000708
		[Token(Token = "0x170000B4")]
		internal Guid idDontGenerate
		{
			[Token(Token = "0x60001AD")]
			[Address(RVA = "0x55D3670", Offset = "0x55D2270", VA = "0x1855D3670")]
			get
			{
				return default(Guid);
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060001AE RID: 430 RVA: 0x00002520 File Offset: 0x00000720
		[Token(Token = "0x170000B5")]
		public bool enabled
		{
			[Token(Token = "0x60001AE")]
			[Address(RVA = "0x200B850", Offset = "0x200A450", VA = "0x18200B850")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060001AF RID: 431 RVA: 0x00002538 File Offset: 0x00000738
		[Token(Token = "0x170000B6")]
		public ReadOnlyArray<InputAction> actions
		{
			[Token(Token = "0x60001AF")]
			[Address(RVA = "0x55D33B0", Offset = "0x55D1FB0", VA = "0x1855D33B0")]
			get
			{
				return default(ReadOnlyArray<InputAction>);
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x00002550 File Offset: 0x00000750
		[Token(Token = "0x170000B7")]
		public ReadOnlyArray<InputBinding> bindings
		{
			[Token(Token = "0x60001B0")]
			[Address(RVA = "0x55D3470", Offset = "0x55D2070", VA = "0x1855D3470")]
			get
			{
				return default(ReadOnlyArray<InputBinding>);
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000B8")]
		private IEnumerable<InputBinding> bindings
		{
			[Token(Token = "0x60001B1")]
			[Address(RVA = "0x55D3170", Offset = "0x55D1D70", VA = "0x1855D3170", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x00002568 File Offset: 0x00000768
		[Token(Token = "0x170000B9")]
		public ReadOnlyArray<InputControlScheme> controlSchemes
		{
			[Token(Token = "0x60001B2")]
			[Address(RVA = "0x55D34D0", Offset = "0x55D20D0", VA = "0x1855D34D0", Slot = "14")]
			get
			{
				return default(ReadOnlyArray<InputControlScheme>);
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x00002580 File Offset: 0x00000780
		// (set) Token: 0x060001B4 RID: 436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000BA")]
		public InputBinding? bindingMask
		{
			[Token(Token = "0x60001B3")]
			[Address(RVA = "0x55D3410", Offset = "0x55D2010", VA = "0x1855D3410", Slot = "10")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B4")]
			[Address(RVA = "0x55D3790", Offset = "0x55D2390", VA = "0x1855D3790", Slot = "11")]
			set
			{
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x00002598 File Offset: 0x00000798
		// (set) Token: 0x060001B6 RID: 438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000BB")]
		public ReadOnlyArray<InputDevice>? devices
		{
			[Token(Token = "0x60001B5")]
			[Address(RVA = "0x55D35B0", Offset = "0x55D21B0", VA = "0x1855D35B0", Slot = "12")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B6")]
			[Address(RVA = "0x55D39B0", Offset = "0x55D25B0", VA = "0x1855D39B0", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x170000BC RID: 188
		[Token(Token = "0x170000BC")]
		public InputAction this[string actionNameOrId]
		{
			[Token(Token = "0x60001B7")]
			[Address(RVA = "0x55D3290", Offset = "0x55D1E90", VA = "0x1855D3290")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x060001B8 RID: 440 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060001B9 RID: 441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000004")]
		public event Action<InputAction.CallbackContext> actionTriggered
		{
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0x55D3240", Offset = "0x55D1E40", VA = "0x1855D3240")]
			add
			{
			}
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0x55D3740", Offset = "0x55D2340", VA = "0x1855D3740")]
			remove
			{
			}
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x55D31F0", Offset = "0x55D1DF0", VA = "0x1855D31F0")]
		public InputActionMap()
		{
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x55D3200", Offset = "0x55D1E00", VA = "0x1855D3200")]
		public InputActionMap(string name)
		{
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x55CFEF0", Offset = "0x55CEAF0", VA = "0x1855CFEF0", Slot = "20")]
		public void Dispose()
		{
		}

		// Token: 0x060001BD RID: 445 RVA: 0x000025B0 File Offset: 0x000007B0
		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x55CFF80", Offset = "0x55CEB80", VA = "0x1855CFF80")]
		internal int FindActionIndex(string nameOrId)
		{
			return 0;
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x55D2240", Offset = "0x55D0E40", VA = "0x1855D2240")]
		private void SetUpActionLookupTable()
		{
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x55CFAF0", Offset = "0x55CE6F0", VA = "0x1855CFAF0")]
		internal void ClearActionLookupTable()
		{
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x000025C8 File Offset: 0x000007C8
		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x55D0310", Offset = "0x55CEF10", VA = "0x1855D0310")]
		private int FindActionIndex(Guid id)
		{
			return 0;
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x55D0530", Offset = "0x55CF130", VA = "0x1855D0530", Slot = "8")]
		public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
		{
			return null;
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x55D0410", Offset = "0x55CF010", VA = "0x1855D0410")]
		public InputAction FindAction(Guid id)
		{
			return null;
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x000025E0 File Offset: 0x000007E0
		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x55D0C70", Offset = "0x55CF870", VA = "0x1855D0C70")]
		public bool IsUsableWithDevice(InputDevice device)
		{
			return default(bool);
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x55CFF10", Offset = "0x55CEB10", VA = "0x1855CFF10", Slot = "16")]
		public void Enable()
		{
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x55CFEC0", Offset = "0x55CEAC0", VA = "0x1855CFEC0", Slot = "17")]
		public void Disable()
		{
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x55CFBA0", Offset = "0x55CE7A0", VA = "0x1855CFBA0")]
		public InputActionMap Clone()
		{
			return null;
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x55D2F10", Offset = "0x55D1B10", VA = "0x1855D2F10", Slot = "4")]
		private object Clone()
		{
			return null;
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x000025F8 File Offset: 0x000007F8
		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x55CFE90", Offset = "0x55CEA90", VA = "0x1855CFE90", Slot = "15")]
		public bool Contains(InputAction action)
		{
			return default(bool);
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x55D30B0", Offset = "0x55D1CB0", VA = "0x1855D30B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x55D0BB0", Offset = "0x55CF7B0", VA = "0x1855D0BB0", Slot = "18")]
		public IEnumerator<InputAction> GetEnumerator()
		{
			return null;
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x55D2E50", Offset = "0x55D1A50", VA = "0x1855D2E50", Slot = "19")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060001CC RID: 460 RVA: 0x00002610 File Offset: 0x00000810
		// (set) Token: 0x060001CD RID: 461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000BD")]
		private bool needToResolveBindings
		{
			[Token(Token = "0x60001CC")]
			[Address(RVA = "0x55D3730", Offset = "0x55D2330", VA = "0x1855D3730")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001CD")]
			[Address(RVA = "0x55D3A00", Offset = "0x55D2600", VA = "0x1855D3A00")]
			set
			{
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060001CE RID: 462 RVA: 0x00002628 File Offset: 0x00000828
		// (set) Token: 0x060001CF RID: 463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000BE")]
		private bool bindingResolutionNeedsFullReResolve
		{
			[Token(Token = "0x60001CE")]
			[Address(RVA = "0x55D3450", Offset = "0x55D2050", VA = "0x1855D3450")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001CF")]
			[Address(RVA = "0x55D3950", Offset = "0x55D2550", VA = "0x1855D3950")]
			set
			{
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x00002640 File Offset: 0x00000840
		// (set) Token: 0x060001D1 RID: 465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000BF")]
		private bool controlsForEachActionInitialized
		{
			[Token(Token = "0x60001D0")]
			[Address(RVA = "0x55D35A0", Offset = "0x55D21A0", VA = "0x1855D35A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001D1")]
			[Address(RVA = "0x55D3990", Offset = "0x55D2590", VA = "0x1855D3990")]
			set
			{
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x00002658 File Offset: 0x00000858
		// (set) Token: 0x060001D3 RID: 467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C0")]
		private bool bindingsForEachActionInitialized
		{
			[Token(Token = "0x60001D2")]
			[Address(RVA = "0x55D3460", Offset = "0x55D2060", VA = "0x1855D3460")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001D3")]
			[Address(RVA = "0x55D3970", Offset = "0x55D2570", VA = "0x1855D3970")]
			set
			{
			}
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00002670 File Offset: 0x00000870
		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x55D0A70", Offset = "0x55CF670", VA = "0x1855D0A70")]
		internal ReadOnlyArray<InputBinding> GetBindingsForSingleAction(InputAction action)
		{
			return default(ReadOnlyArray<InputBinding>);
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00002688 File Offset: 0x00000888
		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x55D0B10", Offset = "0x55CF710", VA = "0x1855D0B10")]
		internal ReadOnlyArray<InputControl> GetControlsForSingleAction(InputAction action)
		{
			return default(ReadOnlyArray<InputControl>);
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x55D23F0", Offset = "0x55D0FF0", VA = "0x1855D23F0")]
		private void SetUpPerActionControlAndBindingArrays()
		{
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x55D12B0", Offset = "0x55CFEB0", VA = "0x1855D12B0")]
		internal void OnWantToChangeSetup()
		{
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x55D1020", Offset = "0x55CFC20", VA = "0x1855D1020")]
		internal void OnSetupChanged()
		{
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x55D0FB0", Offset = "0x55CFBB0", VA = "0x1855D0FB0")]
		internal void OnBindingModified()
		{
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x55CFB40", Offset = "0x55CE740", VA = "0x1855CFB40")]
		internal void ClearCachedActionData(bool onlyControls = false)
		{
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x55D0A30", Offset = "0x55CF630", VA = "0x1855D0A30")]
		internal void GenerateId()
		{
		}

		// Token: 0x060001DC RID: 476 RVA: 0x000026A0 File Offset: 0x000008A0
		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x55D0DE0", Offset = "0x55CF9E0", VA = "0x1855D0DE0")]
		internal bool LazyResolveBindings(bool fullResolve)
		{
			return default(bool);
		}

		// Token: 0x060001DD RID: 477 RVA: 0x000026B8 File Offset: 0x000008B8
		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x55D1550", Offset = "0x55D0150", VA = "0x1855D1550")]
		internal bool ResolveBindingsIfNecessary()
		{
			return default(bool);
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x55D1590", Offset = "0x55D0190", VA = "0x1855D1590")]
		internal void ResolveBindings()
		{
		}

		// Token: 0x060001DF RID: 479 RVA: 0x000026D0 File Offset: 0x000008D0
		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x55D0720", Offset = "0x55CF320", VA = "0x1855D0720", Slot = "9")]
		public int FindBinding(InputBinding mask, out InputAction action)
		{
			return 0;
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x000026E8 File Offset: 0x000008E8
		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x55D0670", Offset = "0x55CF270", VA = "0x1855D0670")]
		internal int FindBindingRelativeToMap(InputBinding mask)
		{
			return 0;
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x55D0980", Offset = "0x55CF580", VA = "0x1855D0980")]
		public static InputActionMap[] FromJson(string json)
		{
			return null;
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x55D2F20", Offset = "0x55D1B20", VA = "0x1855D2F20")]
		public static string ToJson(IEnumerable<InputActionMap> maps)
		{
			return null;
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x55D2FD0", Offset = "0x55D1BD0", VA = "0x1855D2FD0")]
		public string ToJson()
		{
			return null;
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "5")]
		public void OnBeforeSerialize()
		{
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x55D0E90", Offset = "0x55CFA90", VA = "0x1855D0E90", Slot = "6")]
		public void OnAfterDeserialize()
		{
		}

		// Token: 0x040000BE RID: 190
		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		internal string m_Name;

		// Token: 0x040000BF RID: 191
		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		internal string m_Id;

		// Token: 0x040000C0 RID: 192
		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		internal InputActionAsset m_Asset;

		// Token: 0x040000C1 RID: 193
		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		internal InputAction[] m_Actions;

		// Token: 0x040000C2 RID: 194
		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		internal InputBinding[] m_Bindings;

		// Token: 0x040000C3 RID: 195
		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[NonSerialized]
		private InputBinding[] m_BindingsForEachAction;

		// Token: 0x040000C4 RID: 196
		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[NonSerialized]
		private InputControl[] m_ControlsForEachAction;

		// Token: 0x040000C5 RID: 197
		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[NonSerialized]
		internal int m_EnabledActionsCount;

		// Token: 0x040000C6 RID: 198
		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[NonSerialized]
		internal InputAction m_SingletonAction;

		// Token: 0x040000C7 RID: 199
		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[NonSerialized]
		internal int m_MapIndexInState;

		// Token: 0x040000C8 RID: 200
		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[NonSerialized]
		internal InputActionState m_State;

		// Token: 0x040000C9 RID: 201
		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[NonSerialized]
		internal InputBinding? m_BindingMask;

		// Token: 0x040000CA RID: 202
		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[NonSerialized]
		private InputActionMap.Flags m_Flags;

		// Token: 0x040000CB RID: 203
		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[NonSerialized]
		internal int m_ParameterOverridesCount;

		// Token: 0x040000CC RID: 204
		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[NonSerialized]
		internal InputActionRebindingExtensions.ParameterOverride[] m_ParameterOverrides;

		// Token: 0x040000CD RID: 205
		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[NonSerialized]
		internal InputActionMap.DeviceArray m_Devices;

		// Token: 0x040000CE RID: 206
		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[NonSerialized]
		internal CallbackArray<Action<InputAction.CallbackContext>> m_ActionCallbacks;

		// Token: 0x040000CF RID: 207
		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[NonSerialized]
		internal Dictionary<string, int> m_ActionIndexByNameOrId;

		// Token: 0x040000D0 RID: 208
		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static int s_DeferBindingResolution;

		// Token: 0x02000024 RID: 36
		[Token(Token = "0x2000024")]
		[Flags]
		private enum Flags
		{
			// Token: 0x040000D2 RID: 210
			[Token(Token = "0x40000D2")]
			NeedToResolveBindings = 1,
			// Token: 0x040000D3 RID: 211
			[Token(Token = "0x40000D3")]
			BindingResolutionNeedsFullReResolve = 2,
			// Token: 0x040000D4 RID: 212
			[Token(Token = "0x40000D4")]
			ControlsForEachActionInitialized = 4,
			// Token: 0x040000D5 RID: 213
			[Token(Token = "0x40000D5")]
			BindingsForEachActionInitialized = 8
		}

		// Token: 0x02000025 RID: 37
		[Token(Token = "0x2000025")]
		internal struct DeviceArray
		{
			// Token: 0x060001E6 RID: 486 RVA: 0x00002700 File Offset: 0x00000900
			[Token(Token = "0x60001E6")]
			[Address(RVA = "0x55CD3F0", Offset = "0x55CBFF0", VA = "0x1855CD3F0")]
			public int IndexOf(InputDevice device)
			{
				return 0;
			}

			// Token: 0x060001E7 RID: 487 RVA: 0x00002718 File Offset: 0x00000918
			[Token(Token = "0x60001E7")]
			[Address(RVA = "0x55CD440", Offset = "0x55CC040", VA = "0x1855CD440")]
			public bool Remove(InputDevice device)
			{
				return default(bool);
			}

			// Token: 0x060001E8 RID: 488 RVA: 0x00002730 File Offset: 0x00000930
			[Token(Token = "0x60001E8")]
			[Address(RVA = "0x55CD310", Offset = "0x55CBF10", VA = "0x1855CD310")]
			public ReadOnlyArray<InputDevice>? Get()
			{
				return null;
			}

			// Token: 0x060001E9 RID: 489 RVA: 0x00002748 File Offset: 0x00000948
			[Token(Token = "0x60001E9")]
			[Address(RVA = "0x55CD4F0", Offset = "0x55CC0F0", VA = "0x1855CD4F0")]
			public bool Set(ReadOnlyArray<InputDevice>? devices)
			{
				return default(bool);
			}

			// Token: 0x040000D6 RID: 214
			[Token(Token = "0x40000D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private bool m_HaveValue;

			// Token: 0x040000D7 RID: 215
			[Token(Token = "0x40000D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			private int m_DeviceCount;

			// Token: 0x040000D8 RID: 216
			[Token(Token = "0x40000D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private InputDevice[] m_DeviceArray;
		}

		// Token: 0x02000026 RID: 38
		[Token(Token = "0x2000026")]
		[Serializable]
		internal struct BindingOverrideListJson
		{
			// Token: 0x040000D9 RID: 217
			[Token(Token = "0x40000D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public List<InputActionMap.BindingOverrideJson> bindings;
		}

		// Token: 0x02000027 RID: 39
		[Token(Token = "0x2000027")]
		[Serializable]
		internal struct BindingOverrideJson
		{
			// Token: 0x060001EA RID: 490 RVA: 0x00002760 File Offset: 0x00000960
			[Token(Token = "0x60001EA")]
			[Address(RVA = "0x55CBF70", Offset = "0x55CAB70", VA = "0x1855CBF70")]
			public static InputActionMap.BindingOverrideJson FromBinding(InputBinding binding, string actionName)
			{
				return default(InputActionMap.BindingOverrideJson);
			}

			// Token: 0x060001EB RID: 491 RVA: 0x00002778 File Offset: 0x00000978
			[Token(Token = "0x60001EB")]
			[Address(RVA = "0x55CC070", Offset = "0x55CAC70", VA = "0x1855CC070")]
			public static InputActionMap.BindingOverrideJson FromBinding(InputBinding binding)
			{
				return default(InputActionMap.BindingOverrideJson);
			}

			// Token: 0x060001EC RID: 492 RVA: 0x00002790 File Offset: 0x00000990
			[Token(Token = "0x60001EC")]
			[Address(RVA = "0x55CC1C0", Offset = "0x55CADC0", VA = "0x1855CC1C0")]
			public static InputBinding ToBinding(InputActionMap.BindingOverrideJson bindingOverride)
			{
				return default(InputBinding);
			}

			// Token: 0x040000DA RID: 218
			[Token(Token = "0x40000DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string action;

			// Token: 0x040000DB RID: 219
			[Token(Token = "0x40000DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string id;

			// Token: 0x040000DC RID: 220
			[Token(Token = "0x40000DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string path;

			// Token: 0x040000DD RID: 221
			[Token(Token = "0x40000DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string interactions;

			// Token: 0x040000DE RID: 222
			[Token(Token = "0x40000DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string processors;
		}

		// Token: 0x02000028 RID: 40
		[Token(Token = "0x2000028")]
		[Serializable]
		internal struct BindingJson
		{
			// Token: 0x060001ED RID: 493 RVA: 0x000027A8 File Offset: 0x000009A8
			[Token(Token = "0x60001ED")]
			[Address(RVA = "0x55CBE30", Offset = "0x55CAA30", VA = "0x1855CBE30")]
			public InputBinding ToBinding()
			{
				return default(InputBinding);
			}

			// Token: 0x060001EE RID: 494 RVA: 0x000027C0 File Offset: 0x000009C0
			[Token(Token = "0x60001EE")]
			[Address(RVA = "0x55CBD70", Offset = "0x55CA970", VA = "0x1855CBD70")]
			public static InputActionMap.BindingJson FromBinding(ref InputBinding binding)
			{
				return default(InputActionMap.BindingJson);
			}

			// Token: 0x040000DF RID: 223
			[Token(Token = "0x40000DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string name;

			// Token: 0x040000E0 RID: 224
			[Token(Token = "0x40000E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string id;

			// Token: 0x040000E1 RID: 225
			[Token(Token = "0x40000E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string path;

			// Token: 0x040000E2 RID: 226
			[Token(Token = "0x40000E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string interactions;

			// Token: 0x040000E3 RID: 227
			[Token(Token = "0x40000E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string processors;

			// Token: 0x040000E4 RID: 228
			[Token(Token = "0x40000E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string groups;

			// Token: 0x040000E5 RID: 229
			[Token(Token = "0x40000E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string action;

			// Token: 0x040000E6 RID: 230
			[Token(Token = "0x40000E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool isComposite;

			// Token: 0x040000E7 RID: 231
			[Token(Token = "0x40000E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
			public bool isPartOfComposite;
		}

		// Token: 0x02000029 RID: 41
		[Token(Token = "0x2000029")]
		[Serializable]
		internal struct ReadActionJson
		{
			// Token: 0x060001EF RID: 495 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60001EF")]
			[Address(RVA = "0x55DF710", Offset = "0x55DE310", VA = "0x1855DF710")]
			public InputAction ToAction([Optional] string actionName)
			{
				return null;
			}

			// Token: 0x040000E8 RID: 232
			[Token(Token = "0x40000E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string name;

			// Token: 0x040000E9 RID: 233
			[Token(Token = "0x40000E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string type;

			// Token: 0x040000EA RID: 234
			[Token(Token = "0x40000EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string id;

			// Token: 0x040000EB RID: 235
			[Token(Token = "0x40000EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string expectedControlType;

			// Token: 0x040000EC RID: 236
			[Token(Token = "0x40000EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string expectedControlLayout;

			// Token: 0x040000ED RID: 237
			[Token(Token = "0x40000ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string processors;

			// Token: 0x040000EE RID: 238
			[Token(Token = "0x40000EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string interactions;

			// Token: 0x040000EF RID: 239
			[Token(Token = "0x40000EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool passThrough;

			// Token: 0x040000F0 RID: 240
			[Token(Token = "0x40000F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
			public bool initialStateCheck;

			// Token: 0x040000F1 RID: 241
			[Token(Token = "0x40000F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public InputActionMap.BindingJson[] bindings;
		}

		// Token: 0x0200002A RID: 42
		[Token(Token = "0x200002A")]
		[Serializable]
		internal struct WriteActionJson
		{
			// Token: 0x060001F0 RID: 496 RVA: 0x000027D8 File Offset: 0x000009D8
			[Token(Token = "0x60001F0")]
			[Address(RVA = "0x55E4E50", Offset = "0x55E3A50", VA = "0x1855E4E50")]
			public static InputActionMap.WriteActionJson FromAction(InputAction action)
			{
				return default(InputActionMap.WriteActionJson);
			}

			// Token: 0x040000F2 RID: 242
			[Token(Token = "0x40000F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string name;

			// Token: 0x040000F3 RID: 243
			[Token(Token = "0x40000F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string type;

			// Token: 0x040000F4 RID: 244
			[Token(Token = "0x40000F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string id;

			// Token: 0x040000F5 RID: 245
			[Token(Token = "0x40000F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string expectedControlType;

			// Token: 0x040000F6 RID: 246
			[Token(Token = "0x40000F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string processors;

			// Token: 0x040000F7 RID: 247
			[Token(Token = "0x40000F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string interactions;

			// Token: 0x040000F8 RID: 248
			[Token(Token = "0x40000F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool initialStateCheck;
		}

		// Token: 0x0200002B RID: 43
		[Token(Token = "0x200002B")]
		[Serializable]
		internal struct ReadMapJson
		{
			// Token: 0x040000F9 RID: 249
			[Token(Token = "0x40000F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string name;

			// Token: 0x040000FA RID: 250
			[Token(Token = "0x40000FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string id;

			// Token: 0x040000FB RID: 251
			[Token(Token = "0x40000FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public InputActionMap.ReadActionJson[] actions;

			// Token: 0x040000FC RID: 252
			[Token(Token = "0x40000FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public InputActionMap.BindingJson[] bindings;
		}

		// Token: 0x0200002C RID: 44
		[Token(Token = "0x200002C")]
		[Serializable]
		internal struct WriteMapJson
		{
			// Token: 0x060001F1 RID: 497 RVA: 0x000027F0 File Offset: 0x000009F0
			[Token(Token = "0x60001F1")]
			[Address(RVA = "0x55E52A0", Offset = "0x55E3EA0", VA = "0x1855E52A0")]
			public static InputActionMap.WriteMapJson FromMap(InputActionMap map)
			{
				return default(InputActionMap.WriteMapJson);
			}

			// Token: 0x040000FD RID: 253
			[Token(Token = "0x40000FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string name;

			// Token: 0x040000FE RID: 254
			[Token(Token = "0x40000FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string id;

			// Token: 0x040000FF RID: 255
			[Token(Token = "0x40000FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public InputActionMap.WriteActionJson[] actions;

			// Token: 0x04000100 RID: 256
			[Token(Token = "0x4000100")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public InputActionMap.BindingJson[] bindings;
		}

		// Token: 0x0200002D RID: 45
		[Token(Token = "0x200002D")]
		[Serializable]
		internal struct WriteFileJson
		{
			// Token: 0x060001F2 RID: 498 RVA: 0x00002808 File Offset: 0x00000A08
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x55E4F60", Offset = "0x55E3B60", VA = "0x1855E4F60")]
			public static InputActionMap.WriteFileJson FromMap(InputActionMap map)
			{
				return default(InputActionMap.WriteFileJson);
			}

			// Token: 0x060001F3 RID: 499 RVA: 0x00002820 File Offset: 0x00000A20
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0x55E5000", Offset = "0x55E3C00", VA = "0x1855E5000")]
			public static InputActionMap.WriteFileJson FromMaps(IEnumerable<InputActionMap> maps)
			{
				return default(InputActionMap.WriteFileJson);
			}

			// Token: 0x04000101 RID: 257
			[Token(Token = "0x4000101")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public InputActionMap.WriteMapJson[] maps;
		}

		// Token: 0x0200002E RID: 46
		[Token(Token = "0x200002E")]
		[Serializable]
		internal struct ReadFileJson
		{
			// Token: 0x060001F4 RID: 500 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60001F4")]
			[Address(RVA = "0x55DFA80", Offset = "0x55DE680", VA = "0x1855DFA80")]
			public InputActionMap[] ToMaps()
			{
				return null;
			}

			// Token: 0x04000102 RID: 258
			[Token(Token = "0x4000102")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public InputActionMap.ReadActionJson[] actions;

			// Token: 0x04000103 RID: 259
			[Token(Token = "0x4000103")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public InputActionMap.ReadMapJson[] maps;
		}
	}
}
