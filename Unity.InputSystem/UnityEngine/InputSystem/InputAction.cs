using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Utilities;
using UnityEngine.Serialization;

namespace UnityEngine.InputSystem
{
	// Token: 0x0200001A RID: 26
	[Token(Token = "0x200001A")]
	[Serializable]
	public sealed class InputAction : ICloneable, IDisposable
	{
		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000130 RID: 304 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000083")]
		public string name
		{
			[Token(Token = "0x6000130")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000131 RID: 305 RVA: 0x00002058 File Offset: 0x00000258
		[Token(Token = "0x17000084")]
		public InputActionType type
		{
			[Token(Token = "0x6000131")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return InputActionType.Value;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000132 RID: 306 RVA: 0x00002070 File Offset: 0x00000270
		[Token(Token = "0x17000085")]
		public Guid id
		{
			[Token(Token = "0x6000132")]
			[Address(RVA = "0x55DC150", Offset = "0x55DAD50", VA = "0x1855DC150")]
			get
			{
				return default(Guid);
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000133 RID: 307 RVA: 0x00002088 File Offset: 0x00000288
		[Token(Token = "0x17000086")]
		internal Guid idDontGenerate
		{
			[Token(Token = "0x6000133")]
			[Address(RVA = "0x55DC100", Offset = "0x55DAD00", VA = "0x1855DC100")]
			get
			{
				return default(Guid);
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000134 RID: 308 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000135 RID: 309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000087")]
		public string expectedControlType
		{
			[Token(Token = "0x6000134")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000135")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			set
			{
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000136 RID: 310 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000088")]
		public string processors
		{
			[Token(Token = "0x6000136")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000137 RID: 311 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000089")]
		public string interactions
		{
			[Token(Token = "0x6000137")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000138 RID: 312 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700008A")]
		public InputActionMap actionMap
		{
			[Token(Token = "0x6000138")]
			[Address(RVA = "0x55DBDA0", Offset = "0x55DA9A0", VA = "0x1855DBDA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000139 RID: 313 RVA: 0x000020A0 File Offset: 0x000002A0
		// (set) Token: 0x0600013A RID: 314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700008B")]
		public InputBinding? bindingMask
		{
			[Token(Token = "0x6000139")]
			[Address(RVA = "0x55DBE50", Offset = "0x55DAA50", VA = "0x1855DBE50")]
			get
			{
				return null;
			}
			[Token(Token = "0x600013A")]
			[Address(RVA = "0x55DC3A0", Offset = "0x55DAFA0", VA = "0x1855DC3A0")]
			set
			{
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x0600013B RID: 315 RVA: 0x000020B8 File Offset: 0x000002B8
		[Token(Token = "0x1700008C")]
		public ReadOnlyArray<InputBinding> bindings
		{
			[Token(Token = "0x600013B")]
			[Address(RVA = "0x55DBE90", Offset = "0x55DAA90", VA = "0x1855DBE90")]
			get
			{
				return default(ReadOnlyArray<InputBinding>);
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x0600013C RID: 316 RVA: 0x000020D0 File Offset: 0x000002D0
		[Token(Token = "0x1700008D")]
		public ReadOnlyArray<InputControl> controls
		{
			[Token(Token = "0x600013C")]
			[Address(RVA = "0x55DBF50", Offset = "0x55DAB50", VA = "0x1855DBF50")]
			get
			{
				return default(ReadOnlyArray<InputControl>);
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600013D RID: 317 RVA: 0x000020E8 File Offset: 0x000002E8
		[Token(Token = "0x1700008E")]
		public InputActionPhase phase
		{
			[Token(Token = "0x600013D")]
			[Address(RVA = "0x55DC240", Offset = "0x55DAE40", VA = "0x1855DC240")]
			get
			{
				return InputActionPhase.Disabled;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600013E RID: 318 RVA: 0x00002100 File Offset: 0x00000300
		[Token(Token = "0x1700008F")]
		public bool inProgress
		{
			[Token(Token = "0x600013E")]
			[Address(RVA = "0x55DC1C0", Offset = "0x55DADC0", VA = "0x1855DC1C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600013F RID: 319 RVA: 0x00002118 File Offset: 0x00000318
		[Token(Token = "0x17000090")]
		public bool enabled
		{
			[Token(Token = "0x600013F")]
			[Address(RVA = "0x55DC0A0", Offset = "0x55DACA0", VA = "0x1855DC0A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000140 RID: 320 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000141 RID: 321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000001")]
		public event Action<InputAction.CallbackContext> started
		{
			[Token(Token = "0x6000140")]
			[Address(RVA = "0x55DBD50", Offset = "0x55DA950", VA = "0x1855DBD50")]
			add
			{
			}
			[Token(Token = "0x6000141")]
			[Address(RVA = "0x55DC350", Offset = "0x55DAF50", VA = "0x1855DC350")]
			remove
			{
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000142 RID: 322 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000143 RID: 323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000002")]
		public event Action<InputAction.CallbackContext> canceled
		{
			[Token(Token = "0x6000142")]
			[Address(RVA = "0x55DBCB0", Offset = "0x55DA8B0", VA = "0x1855DBCB0")]
			add
			{
			}
			[Token(Token = "0x6000143")]
			[Address(RVA = "0x55DC2B0", Offset = "0x55DAEB0", VA = "0x1855DC2B0")]
			remove
			{
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000144 RID: 324 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000145 RID: 325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000003")]
		public event Action<InputAction.CallbackContext> performed
		{
			[Token(Token = "0x6000144")]
			[Address(RVA = "0x55DBD00", Offset = "0x55DA900", VA = "0x1855DBD00")]
			add
			{
			}
			[Token(Token = "0x6000145")]
			[Address(RVA = "0x55DC300", Offset = "0x55DAF00", VA = "0x1855DC300")]
			remove
			{
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000146 RID: 326 RVA: 0x00002130 File Offset: 0x00000330
		[Token(Token = "0x17000091")]
		public bool triggered
		{
			[Token(Token = "0x6000146")]
			[Address(RVA = "0x55DB8A0", Offset = "0x55DA4A0", VA = "0x1855DB8A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000147 RID: 327 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000092")]
		public InputControl activeControl
		{
			[Token(Token = "0x6000147")]
			[Address(RVA = "0x55DBDC0", Offset = "0x55DA9C0", VA = "0x1855DBDC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000148 RID: 328 RVA: 0x00002148 File Offset: 0x00000348
		// (set) Token: 0x06000149 RID: 329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000093")]
		public bool wantsInitialStateCheck
		{
			[Token(Token = "0x6000148")]
			[Address(RVA = "0x55DC2A0", Offset = "0x55DAEA0", VA = "0x1855DC2A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000149")]
			[Address(RVA = "0x55DC670", Offset = "0x55DB270", VA = "0x1855DC670")]
			set
			{
			}
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600014A")]
		[Address(RVA = "0x55DBA50", Offset = "0x55DA650", VA = "0x1855DBA50")]
		public InputAction()
		{
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600014B")]
		[Address(RVA = "0x55DBAA0", Offset = "0x55DA6A0", VA = "0x1855DBAA0")]
		public InputAction([Optional] string name, InputActionType type = InputActionType.Value, [Optional] string binding, [Optional] string interactions, [Optional] string processors, [Optional] string expectedControlType)
		{
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600014C")]
		[Address(RVA = "0x55DADD0", Offset = "0x55D99D0", VA = "0x1855DADD0", Slot = "5")]
		public void Dispose()
		{
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600014D")]
		[Address(RVA = "0x55DB580", Offset = "0x55DA180", VA = "0x1855DB580", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600014E")]
		[Address(RVA = "0x55DADF0", Offset = "0x55D99F0", VA = "0x1855DADF0")]
		public void Enable()
		{
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600014F")]
		[Address(RVA = "0x55DAD50", Offset = "0x55D9950", VA = "0x1855DAD50")]
		public void Disable()
		{
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000150")]
		[Address(RVA = "0x55DAAA0", Offset = "0x55D96A0", VA = "0x1855DAAA0")]
		public InputAction Clone()
		{
			return null;
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000151")]
		[Address(RVA = "0x55DAAA0", Offset = "0x55D96A0", VA = "0x1855DAAA0", Slot = "4")]
		private object Clone()
		{
			return null;
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000152")]
		public TValue ReadValue<TValue>() where TValue : struct
		{
			return null;
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000153")]
		[Address(RVA = "0x55DB400", Offset = "0x55DA000", VA = "0x1855DB400")]
		public object ReadValueAsObject()
		{
			return null;
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000154")]
		[Address(RVA = "0x55DB4E0", Offset = "0x55DA0E0", VA = "0x1855DB4E0")]
		public void Reset()
		{
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00002160 File Offset: 0x00000360
		[Token(Token = "0x6000155")]
		[Address(RVA = "0x55DB350", Offset = "0x55D9F50", VA = "0x1855DB350")]
		public bool IsPressed()
		{
			return default(bool);
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00002178 File Offset: 0x00000378
		[Token(Token = "0x6000156")]
		[Address(RVA = "0x55DB2F0", Offset = "0x55D9EF0", VA = "0x1855DB2F0")]
		public bool IsInProgress()
		{
			return default(bool);
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00002190 File Offset: 0x00000390
		[Token(Token = "0x6000157")]
		[Address(RVA = "0x55DB930", Offset = "0x55DA530", VA = "0x1855DB930")]
		public bool WasPressedThisFrame()
		{
			return default(bool);
		}

		// Token: 0x06000158 RID: 344 RVA: 0x000021A8 File Offset: 0x000003A8
		[Token(Token = "0x6000158")]
		[Address(RVA = "0x55DB9C0", Offset = "0x55DA5C0", VA = "0x1855DB9C0")]
		public bool WasReleasedThisFrame()
		{
			return default(bool);
		}

		// Token: 0x06000159 RID: 345 RVA: 0x000021C0 File Offset: 0x000003C0
		[Token(Token = "0x6000159")]
		[Address(RVA = "0x55DB8A0", Offset = "0x55DA4A0", VA = "0x1855DB8A0")]
		public bool WasPerformedThisFrame()
		{
			return default(bool);
		}

		// Token: 0x0600015A RID: 346 RVA: 0x000021D8 File Offset: 0x000003D8
		[Token(Token = "0x600015A")]
		[Address(RVA = "0x55DB160", Offset = "0x55D9D60", VA = "0x1855DB160")]
		public float GetTimeoutCompletionPercentage()
		{
			return 0f;
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600015B RID: 347 RVA: 0x000021F0 File Offset: 0x000003F0
		[Token(Token = "0x17000094")]
		internal bool isSingletonAction
		{
			[Token(Token = "0x600015B")]
			[Address(RVA = "0x55DC220", Offset = "0x55DAE20", VA = "0x1855DC220")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x0600015C RID: 348 RVA: 0x00002208 File Offset: 0x00000408
		[Token(Token = "0x17000095")]
		private InputActionState.TriggerState currentState
		{
			[Token(Token = "0x600015C")]
			[Address(RVA = "0x55DC030", Offset = "0x55DAC30", VA = "0x1855DC030")]
			get
			{
				return default(InputActionState.TriggerState);
			}
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600015D")]
		[Address(RVA = "0x55DB3B0", Offset = "0x55D9FB0", VA = "0x1855DB3B0")]
		internal string MakeSureIdIsInPlace()
		{
			return null;
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600015E")]
		[Address(RVA = "0x55DAFD0", Offset = "0x55D9BD0", VA = "0x1855DAFD0")]
		internal void GenerateId()
		{
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600015F")]
		[Address(RVA = "0x55DB010", Offset = "0x55D9C10", VA = "0x1855DB010")]
		internal InputActionMap GetOrCreateActionMap()
		{
			return null;
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000160")]
		[Address(RVA = "0x55DAC30", Offset = "0x55D9830", VA = "0x1855DAC30")]
		private void CreateInternalActionMapForSingletonAction()
		{
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000161")]
		[Address(RVA = "0x55DB4A0", Offset = "0x55DA0A0", VA = "0x1855DB4A0")]
		internal void RequestInitialStateCheckOnEnabledAction()
		{
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00002220 File Offset: 0x00000420
		[Token(Token = "0x6000162")]
		[Address(RVA = "0x55DA6D0", Offset = "0x55D92D0", VA = "0x1855DA6D0")]
		internal bool ActiveControlIsValid(InputControl control)
		{
			return default(bool);
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00002238 File Offset: 0x00000438
		[Token(Token = "0x6000163")]
		[Address(RVA = "0x55DAEA0", Offset = "0x55D9AA0", VA = "0x1855DAEA0")]
		internal InputBinding? FindEffectiveBindingMask()
		{
			return null;
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00002250 File Offset: 0x00000450
		[Token(Token = "0x6000164")]
		[Address(RVA = "0x55DA850", Offset = "0x55D9450", VA = "0x1855DA850")]
		internal int BindingIndexOnActionToBindingIndexOnMap(int indexOfBindingOnAction)
		{
			return 0;
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00002268 File Offset: 0x00000468
		[Token(Token = "0x6000165")]
		[Address(RVA = "0x55DA9F0", Offset = "0x55D95F0", VA = "0x1855DA9F0")]
		internal int BindingIndexOnMapToBindingIndexOnAction(int indexOfBindingOnMap)
		{
			return 0;
		}

		// Token: 0x04000080 RID: 128
		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("Human readable name of the action. Must be unique within its action map (case is ignored). Can be changed without breaking references to the action.")]
		[SerializeField]
		internal string m_Name;

		// Token: 0x04000081 RID: 129
		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Determines how the action triggers.\n\nA Value action will start and perform when a control moves from its default value and then perform on every value change. It will cancel when controls go back to default value. Also, when enabled, a Value action will respond right away to a control's current value.\n\nA Button action will start when a button is pressed and perform when the press threshold (see 'Default Button Press Point' in settings) is reached. It will cancel when the button is going below the release threshold (see 'Button Release Threshold' in settings). Also, if a button is already pressed when the action is enabled, the button has to be released first.\n\nA Pass-Through action will not explicitly start and will never cancel. Instead, for every value change on any bound control, the action will perform.")]
		[SerializeField]
		internal InputActionType m_Type;

		// Token: 0x04000082 RID: 130
		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[FormerlySerializedAs("m_ExpectedControlLayout")]
		[SerializeField]
		[Tooltip("The type of control expected by the action (e.g. \"Button\" or \"Stick\"). This will limit the controls shown when setting up bindings in the UI and will also limit which controls can be bound interactively to the action.")]
		internal string m_ExpectedControlType;

		// Token: 0x04000083 RID: 131
		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Unique ID of the action (GUID). Used to reference the action from bindings such that actions can be renamed without breaking references.")]
		[SerializeField]
		internal string m_Id;

		// Token: 0x04000084 RID: 132
		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		internal string m_Processors;

		// Token: 0x04000085 RID: 133
		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		internal string m_Interactions;

		// Token: 0x04000086 RID: 134
		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		internal InputBinding[] m_SingletonActionBindings;

		// Token: 0x04000087 RID: 135
		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		internal InputAction.ActionFlags m_Flags;

		// Token: 0x04000088 RID: 136
		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[NonSerialized]
		internal InputBinding? m_BindingMask;

		// Token: 0x04000089 RID: 137
		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[NonSerialized]
		internal int m_BindingsStartIndex;

		// Token: 0x0400008A RID: 138
		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[NonSerialized]
		internal int m_BindingsCount;

		// Token: 0x0400008B RID: 139
		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[NonSerialized]
		internal int m_ControlStartIndex;

		// Token: 0x0400008C RID: 140
		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[NonSerialized]
		internal int m_ControlCount;

		// Token: 0x0400008D RID: 141
		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[NonSerialized]
		internal int m_ActionIndexInState;

		// Token: 0x0400008E RID: 142
		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[NonSerialized]
		internal InputActionMap m_ActionMap;

		// Token: 0x0400008F RID: 143
		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[NonSerialized]
		internal CallbackArray<Action<InputAction.CallbackContext>> m_OnStarted;

		// Token: 0x04000090 RID: 144
		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[NonSerialized]
		internal CallbackArray<Action<InputAction.CallbackContext>> m_OnCanceled;

		// Token: 0x04000091 RID: 145
		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		[NonSerialized]
		internal CallbackArray<Action<InputAction.CallbackContext>> m_OnPerformed;

		// Token: 0x0200001B RID: 27
		[Token(Token = "0x200001B")]
		[Flags]
		internal enum ActionFlags
		{
			// Token: 0x04000093 RID: 147
			[Token(Token = "0x4000093")]
			WantsInitialStateCheck = 1
		}

		// Token: 0x0200001C RID: 28
		[Token(Token = "0x200001C")]
		public struct CallbackContext
		{
			// Token: 0x17000096 RID: 150
			// (get) Token: 0x06000166 RID: 358 RVA: 0x00002280 File Offset: 0x00000480
			[Token(Token = "0x17000096")]
			private int actionIndex
			{
				[Token(Token = "0x6000166")]
				[Address(RVA = "0x116A510", Offset = "0x1169110", VA = "0x18116A510")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000097 RID: 151
			// (get) Token: 0x06000167 RID: 359 RVA: 0x00002298 File Offset: 0x00000498
			[Token(Token = "0x17000097")]
			private int bindingIndex
			{
				[Token(Token = "0x6000167")]
				[Address(RVA = "0x55CCAA0", Offset = "0x55CB6A0", VA = "0x1855CCAA0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000098 RID: 152
			// (get) Token: 0x06000168 RID: 360 RVA: 0x000022B0 File Offset: 0x000004B0
			[Token(Token = "0x17000098")]
			private int controlIndex
			{
				[Token(Token = "0x6000168")]
				[Address(RVA = "0x55CCB20", Offset = "0x55CB720", VA = "0x1855CCB20")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000099 RID: 153
			// (get) Token: 0x06000169 RID: 361 RVA: 0x000022C8 File Offset: 0x000004C8
			[Token(Token = "0x17000099")]
			private int interactionIndex
			{
				[Token(Token = "0x6000169")]
				[Address(RVA = "0x55CCC50", Offset = "0x55CB850", VA = "0x1855CCC50")]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700009A RID: 154
			// (get) Token: 0x0600016A RID: 362 RVA: 0x000022E0 File Offset: 0x000004E0
			[Token(Token = "0x1700009A")]
			public InputActionPhase phase
			{
				[Token(Token = "0x600016A")]
				[Address(RVA = "0x55CCD40", Offset = "0x55CB940", VA = "0x1855CCD40")]
				get
				{
					return InputActionPhase.Disabled;
				}
			}

			// Token: 0x1700009B RID: 155
			// (get) Token: 0x0600016B RID: 363 RVA: 0x000022F8 File Offset: 0x000004F8
			[Token(Token = "0x1700009B")]
			public bool started
			{
				[Token(Token = "0x600016B")]
				[Address(RVA = "0x55CCDC0", Offset = "0x55CB9C0", VA = "0x1855CCDC0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700009C RID: 156
			// (get) Token: 0x0600016C RID: 364 RVA: 0x00002310 File Offset: 0x00000510
			[Token(Token = "0x1700009C")]
			public bool performed
			{
				[Token(Token = "0x600016C")]
				[Address(RVA = "0x55CCD00", Offset = "0x55CB900", VA = "0x1855CCD00")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700009D RID: 157
			// (get) Token: 0x0600016D RID: 365 RVA: 0x00002328 File Offset: 0x00000528
			[Token(Token = "0x1700009D")]
			public bool canceled
			{
				[Token(Token = "0x600016D")]
				[Address(RVA = "0x55CCAE0", Offset = "0x55CB6E0", VA = "0x1855CCAE0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700009E RID: 158
			// (get) Token: 0x0600016E RID: 366 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700009E")]
			public InputAction action
			{
				[Token(Token = "0x600016E")]
				[Address(RVA = "0x55CCA40", Offset = "0x55CB640", VA = "0x1855CCA40")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700009F RID: 159
			// (get) Token: 0x0600016F RID: 367 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700009F")]
			public InputControl control
			{
				[Token(Token = "0x600016F")]
				[Address(RVA = "0x55CCB60", Offset = "0x55CB760", VA = "0x1855CCB60")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000A0 RID: 160
			// (get) Token: 0x06000170 RID: 368 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170000A0")]
			public IInputInteraction interaction
			{
				[Token(Token = "0x6000170")]
				[Address(RVA = "0x55CCC90", Offset = "0x55CB890", VA = "0x1855CCC90")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000A1 RID: 161
			// (get) Token: 0x06000171 RID: 369 RVA: 0x00002340 File Offset: 0x00000540
			[Token(Token = "0x170000A1")]
			public double time
			{
				[Token(Token = "0x6000171")]
				[Address(RVA = "0x55CCE00", Offset = "0x55CBA00", VA = "0x1855CCE00")]
				get
				{
					return 0.0;
				}
			}

			// Token: 0x170000A2 RID: 162
			// (get) Token: 0x06000172 RID: 370 RVA: 0x00002358 File Offset: 0x00000558
			[Token(Token = "0x170000A2")]
			public double startTime
			{
				[Token(Token = "0x6000172")]
				[Address(RVA = "0x55CCD80", Offset = "0x55CB980", VA = "0x1855CCD80")]
				get
				{
					return 0.0;
				}
			}

			// Token: 0x170000A3 RID: 163
			// (get) Token: 0x06000173 RID: 371 RVA: 0x00002370 File Offset: 0x00000570
			[Token(Token = "0x170000A3")]
			public double duration
			{
				[Token(Token = "0x6000173")]
				[Address(RVA = "0x55CCBD0", Offset = "0x55CB7D0", VA = "0x1855CCBD0")]
				get
				{
					return 0.0;
				}
			}

			// Token: 0x170000A4 RID: 164
			// (get) Token: 0x06000174 RID: 372 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170000A4")]
			public Type valueType
			{
				[Token(Token = "0x6000174")]
				[Address(RVA = "0x55CCED0", Offset = "0x55CBAD0", VA = "0x1855CCED0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000A5 RID: 165
			// (get) Token: 0x06000175 RID: 373 RVA: 0x00002388 File Offset: 0x00000588
			[Token(Token = "0x170000A5")]
			public int valueSizeInBytes
			{
				[Token(Token = "0x6000175")]
				[Address(RVA = "0x55CCE40", Offset = "0x55CBA40", VA = "0x1855CCE40")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06000176 RID: 374 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000176")]
			[Address(RVA = "0x55CC480", Offset = "0x55CB080", VA = "0x1855CC480")]
			public unsafe void ReadValue(void* buffer, int bufferSize)
			{
			}

			// Token: 0x06000177 RID: 375 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000177")]
			public TValue ReadValue<TValue>() where TValue : struct
			{
				return null;
			}

			// Token: 0x06000178 RID: 376 RVA: 0x000023A0 File Offset: 0x000005A0
			[Token(Token = "0x6000178")]
			[Address(RVA = "0x55CC300", Offset = "0x55CAF00", VA = "0x1855CC300")]
			public bool ReadValueAsButton()
			{
				return default(bool);
			}

			// Token: 0x06000179 RID: 377 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000179")]
			[Address(RVA = "0x55CC3C0", Offset = "0x55CAFC0", VA = "0x1855CC3C0")]
			public object ReadValueAsObject()
			{
				return null;
			}

			// Token: 0x0600017A RID: 378 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600017A")]
			[Address(RVA = "0x55CC6A0", Offset = "0x55CB2A0", VA = "0x1855CC6A0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x04000094 RID: 148
			[Token(Token = "0x4000094")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal InputActionState m_State;

			// Token: 0x04000095 RID: 149
			[Token(Token = "0x4000095")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal int m_ActionIndex;
		}
	}
}
