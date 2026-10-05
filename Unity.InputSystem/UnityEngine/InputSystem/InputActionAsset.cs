using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem
{
	// Token: 0x0200001D RID: 29
	[Token(Token = "0x200001D")]
	public class InputActionAsset : ScriptableObject, IInputActionCollection2, IInputActionCollection, IEnumerable<InputAction>, IEnumerable
	{
		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x0600017B RID: 379 RVA: 0x000023B8 File Offset: 0x000005B8
		[Token(Token = "0x170000A6")]
		public bool enabled
		{
			[Token(Token = "0x600017B")]
			[Address(RVA = "0x55CF730", Offset = "0x55CE330", VA = "0x1855CF730")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600017C RID: 380 RVA: 0x000023D0 File Offset: 0x000005D0
		[Token(Token = "0x170000A7")]
		public ReadOnlyArray<InputActionMap> actionMaps
		{
			[Token(Token = "0x600017C")]
			[Address(RVA = "0x55CF570", Offset = "0x55CE170", VA = "0x1855CF570")]
			get
			{
				return default(ReadOnlyArray<InputActionMap>);
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600017D RID: 381 RVA: 0x000023E8 File Offset: 0x000005E8
		[Token(Token = "0x170000A8")]
		public ReadOnlyArray<InputControlScheme> controlSchemes
		{
			[Token(Token = "0x600017D")]
			[Address(RVA = "0x55CF690", Offset = "0x55CE290", VA = "0x1855CF690", Slot = "11")]
			get
			{
				return default(ReadOnlyArray<InputControlScheme>);
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x0600017E RID: 382 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000A9")]
		public IEnumerable<InputBinding> bindings
		{
			[Token(Token = "0x600017E")]
			[Address(RVA = "0x55CF610", Offset = "0x55CE210", VA = "0x1855CF610", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x0600017F RID: 383 RVA: 0x00002400 File Offset: 0x00000600
		// (set) Token: 0x06000180 RID: 384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000AA")]
		public InputBinding? bindingMask
		{
			[Token(Token = "0x600017F")]
			[Address(RVA = "0x55CF5D0", Offset = "0x55CE1D0", VA = "0x1855CF5D0", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000180")]
			[Address(RVA = "0x55CF890", Offset = "0x55CE490", VA = "0x1855CF890", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000181 RID: 385 RVA: 0x00002418 File Offset: 0x00000618
		// (set) Token: 0x06000182 RID: 386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000AB")]
		public ReadOnlyArray<InputDevice>? devices
		{
			[Token(Token = "0x6000181")]
			[Address(RVA = "0x55CF6F0", Offset = "0x55CE2F0", VA = "0x1855CF6F0", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000182")]
			[Address(RVA = "0x55CFA70", Offset = "0x55CE670", VA = "0x1855CFA70", Slot = "10")]
			set
			{
			}
		}

		// Token: 0x170000AC RID: 172
		[Token(Token = "0x170000AC")]
		public InputAction this[string actionNameOrId]
		{
			[Token(Token = "0x6000183")]
			[Address(RVA = "0x55CF4E0", Offset = "0x55CE0E0", VA = "0x1855CF4E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000184")]
		[Address(RVA = "0x55CF420", Offset = "0x55CE020", VA = "0x1855CF420")]
		public string ToJson()
		{
			return null;
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000185")]
		[Address(RVA = "0x55CF130", Offset = "0x55CDD30", VA = "0x1855CF130")]
		public void LoadFromJson(string json)
		{
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000186")]
		[Address(RVA = "0x55CECA0", Offset = "0x55CD8A0", VA = "0x1855CECA0")]
		public static InputActionAsset FromJson(string json)
		{
			return null;
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000187")]
		[Address(RVA = "0x55CE460", Offset = "0x55CD060", VA = "0x1855CE460", Slot = "5")]
		public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
		{
			return null;
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00002430 File Offset: 0x00000630
		[Token(Token = "0x6000188")]
		[Address(RVA = "0x55CE860", Offset = "0x55CD460", VA = "0x1855CE860", Slot = "6")]
		public int FindBinding(InputBinding mask, out InputAction action)
		{
			return 0;
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000189")]
		[Address(RVA = "0x55CDF30", Offset = "0x55CCB30", VA = "0x1855CDF30")]
		public InputActionMap FindActionMap(string nameOrId, bool throwIfNotFound = false)
		{
			return null;
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600018A")]
		[Address(RVA = "0x55CE1D0", Offset = "0x55CCDD0", VA = "0x1855CE1D0")]
		public InputActionMap FindActionMap(Guid id)
		{
			return null;
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600018B")]
		[Address(RVA = "0x55CE2D0", Offset = "0x55CCED0", VA = "0x1855CE2D0")]
		public InputAction FindAction(Guid guid)
		{
			return null;
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00002448 File Offset: 0x00000648
		[Token(Token = "0x600018C")]
		[Address(RVA = "0x55CE980", Offset = "0x55CD580", VA = "0x1855CE980")]
		public int FindControlSchemeIndex(string name)
		{
			return 0;
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00002460 File Offset: 0x00000660
		[Token(Token = "0x600018D")]
		[Address(RVA = "0x55CEA80", Offset = "0x55CD680", VA = "0x1855CEA80")]
		public InputControlScheme? FindControlScheme(string name)
		{
			return null;
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00002478 File Offset: 0x00000678
		[Token(Token = "0x600018E")]
		[Address(RVA = "0x55CEEA0", Offset = "0x55CDAA0", VA = "0x1855CEEA0")]
		public bool IsUsableWithDevice(InputDevice device)
		{
			return default(bool);
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018F")]
		[Address(RVA = "0x55CDD90", Offset = "0x55CC990", VA = "0x1855CDD90", Slot = "13")]
		public void Enable()
		{
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000190")]
		[Address(RVA = "0x55CDC30", Offset = "0x55CC830", VA = "0x1855CDC30", Slot = "14")]
		public void Disable()
		{
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00002490 File Offset: 0x00000690
		[Token(Token = "0x6000191")]
		[Address(RVA = "0x55CDBA0", Offset = "0x55CC7A0", VA = "0x1855CDBA0", Slot = "12")]
		public bool Contains(InputAction action)
		{
			return default(bool);
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000192")]
		[Address(RVA = "0x55CEE20", Offset = "0x55CDA20", VA = "0x1855CEE20", Slot = "15")]
		public IEnumerator<InputAction> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000193")]
		[Address(RVA = "0x55CEE20", Offset = "0x55CDA20", VA = "0x1855CEE20", Slot = "16")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000194")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		internal void MarkAsDirty()
		{
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000195")]
		[Address(RVA = "0x55CF2C0", Offset = "0x55CDEC0", VA = "0x1855CF2C0")]
		internal void OnWantToChangeSetup()
		{
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000196")]
		[Address(RVA = "0x55CF240", Offset = "0x55CDE40", VA = "0x1855CF240")]
		internal void OnSetupChanged()
		{
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000197")]
		[Address(RVA = "0x55CF330", Offset = "0x55CDF30", VA = "0x1855CF330")]
		private void ReResolveIfNecessary(bool fullResolve)
		{
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000198")]
		[Address(RVA = "0x55CF370", Offset = "0x55CDF70", VA = "0x1855CF370")]
		internal void ResolveBindingsIfNecessary()
		{
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000199")]
		[Address(RVA = "0x55CF200", Offset = "0x55CDE00", VA = "0x1855CF200")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019A")]
		[Address(RVA = "0x4F4B00", Offset = "0x4F3700", VA = "0x1804F4B00")]
		public InputActionAsset()
		{
		}

		// Token: 0x04000096 RID: 150
		[Token(Token = "0x4000096")]
		public const string Extension = "inputactions";

		// Token: 0x04000097 RID: 151
		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		internal InputActionMap[] m_ActionMaps;

		// Token: 0x04000098 RID: 152
		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		internal InputControlScheme[] m_ControlSchemes;

		// Token: 0x04000099 RID: 153
		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		internal InputActionState m_SharedStateForAllMaps;

		// Token: 0x0400009A RID: 154
		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		internal InputBinding? m_BindingMask;

		// Token: 0x0400009B RID: 155
		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x90")]
		[NonSerialized]
		internal int m_ParameterOverridesCount;

		// Token: 0x0400009C RID: 156
		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x98")]
		[NonSerialized]
		internal InputActionRebindingExtensions.ParameterOverride[] m_ParameterOverrides;

		// Token: 0x0400009D RID: 157
		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0xA0")]
		[NonSerialized]
		internal InputActionMap.DeviceArray m_Devices;

		// Token: 0x0200001E RID: 30
		[Token(Token = "0x200001E")]
		[Serializable]
		internal struct WriteFileJson
		{
			// Token: 0x0400009E RID: 158
			[Token(Token = "0x400009E")]
			[FieldOffset(Offset = "0x0")]
			public string name;

			// Token: 0x0400009F RID: 159
			[Token(Token = "0x400009F")]
			[FieldOffset(Offset = "0x8")]
			public InputActionMap.WriteMapJson[] maps;

			// Token: 0x040000A0 RID: 160
			[Token(Token = "0x40000A0")]
			[FieldOffset(Offset = "0x10")]
			public InputControlScheme.SchemeJson[] controlSchemes;
		}

		// Token: 0x0200001F RID: 31
		[Token(Token = "0x200001F")]
		[Serializable]
		internal struct ReadFileJson
		{
			// Token: 0x0600019B RID: 411 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600019B")]
			[Address(RVA = "0x55DF9A0", Offset = "0x55DE5A0", VA = "0x1855DF9A0")]
			public void ToAsset(InputActionAsset asset)
			{
			}

			// Token: 0x040000A1 RID: 161
			[Token(Token = "0x40000A1")]
			[FieldOffset(Offset = "0x0")]
			public string name;

			// Token: 0x040000A2 RID: 162
			[Token(Token = "0x40000A2")]
			[FieldOffset(Offset = "0x8")]
			public InputActionMap.ReadMapJson[] maps;

			// Token: 0x040000A3 RID: 163
			[Token(Token = "0x40000A3")]
			[FieldOffset(Offset = "0x10")]
			public InputControlScheme.SchemeJson[] controlSchemes;
		}
	}
}
