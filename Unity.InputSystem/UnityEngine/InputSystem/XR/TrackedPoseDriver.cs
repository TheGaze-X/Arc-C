using System;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.XR
{
	// Token: 0x020000DF RID: 223
	[Token(Token = "0x20000DF")]
	[AddComponentMenu("XR/Tracked Pose Driver (Input System)")]
	[Serializable]
	public class TrackedPoseDriver : MonoBehaviour, ISerializationCallbackReceiver
	{
		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000BC4 RID: 3012 RVA: 0x00005B80 File Offset: 0x00003D80
		// (set) Token: 0x06000BC5 RID: 3013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700030D")]
		public TrackedPoseDriver.TrackingType trackingType
		{
			[Token(Token = "0x6000BC4")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return TrackedPoseDriver.TrackingType.RotationAndPosition;
			}
			[Token(Token = "0x6000BC5")]
			[Address(RVA = "0x4EA9A0", Offset = "0x4E95A0", VA = "0x1804EA9A0")]
			set
			{
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000BC6 RID: 3014 RVA: 0x00005B98 File Offset: 0x00003D98
		// (set) Token: 0x06000BC7 RID: 3015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700030E")]
		public TrackedPoseDriver.UpdateType updateType
		{
			[Token(Token = "0x6000BC6")]
			[Address(RVA = "0x4EA880", Offset = "0x4E9480", VA = "0x1804EA880")]
			get
			{
				return TrackedPoseDriver.UpdateType.UpdateAndBeforeRender;
			}
			[Token(Token = "0x6000BC7")]
			[Address(RVA = "0x4EAC10", Offset = "0x4E9810", VA = "0x1804EAC10")]
			set
			{
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000BC8 RID: 3016 RVA: 0x00005BB0 File Offset: 0x00003DB0
		// (set) Token: 0x06000BC9 RID: 3017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700030F")]
		public bool ignoreTrackingState
		{
			[Token(Token = "0x6000BC8")]
			[Address(RVA = "0x4F1E20", Offset = "0x4F0A20", VA = "0x1804F1E20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000BC9")]
			[Address(RVA = "0x4F1E30", Offset = "0x4F0A30", VA = "0x1804F1E30")]
			set
			{
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000BCA RID: 3018 RVA: 0x00005BC8 File Offset: 0x00003DC8
		// (set) Token: 0x06000BCB RID: 3019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000310")]
		public InputActionProperty positionInput
		{
			[Token(Token = "0x6000BCA")]
			[Address(RVA = "0x4013E30", Offset = "0x4012A30", VA = "0x184013E30")]
			get
			{
				return default(InputActionProperty);
			}
			[Token(Token = "0x6000BCB")]
			[Address(RVA = "0x56B2260", Offset = "0x56B0E60", VA = "0x1856B2260")]
			set
			{
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000BCC RID: 3020 RVA: 0x00005BE0 File Offset: 0x00003DE0
		// (set) Token: 0x06000BCD RID: 3021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000311")]
		public InputActionProperty rotationInput
		{
			[Token(Token = "0x6000BCC")]
			[Address(RVA = "0x4BED450", Offset = "0x4BEC050", VA = "0x184BED450")]
			get
			{
				return default(InputActionProperty);
			}
			[Token(Token = "0x6000BCD")]
			[Address(RVA = "0x56B2370", Offset = "0x56B0F70", VA = "0x1856B2370")]
			set
			{
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000BCE RID: 3022 RVA: 0x00005BF8 File Offset: 0x00003DF8
		// (set) Token: 0x06000BCF RID: 3023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000312")]
		public InputActionProperty trackingStateInput
		{
			[Token(Token = "0x6000BCE")]
			[Address(RVA = "0x25378C0", Offset = "0x25364C0", VA = "0x1825378C0")]
			get
			{
				return default(InputActionProperty);
			}
			[Token(Token = "0x6000BCF")]
			[Address(RVA = "0x56B23E0", Offset = "0x56B0FE0", VA = "0x1856B23E0")]
			set
			{
			}
		}

		// Token: 0x06000BD0 RID: 3024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BD0")]
		[Address(RVA = "0x56B0A60", Offset = "0x56AF660", VA = "0x1856B0A60")]
		private void BindActions()
		{
		}

		// Token: 0x06000BD1 RID: 3025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BD1")]
		[Address(RVA = "0x56B1990", Offset = "0x56B0590", VA = "0x1856B1990")]
		private void UnbindActions()
		{
		}

		// Token: 0x06000BD2 RID: 3026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BD2")]
		[Address(RVA = "0x56B0A90", Offset = "0x56AF690", VA = "0x1856B0A90")]
		private void BindPosition()
		{
		}

		// Token: 0x06000BD3 RID: 3027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BD3")]
		[Address(RVA = "0x56B0C30", Offset = "0x56AF830", VA = "0x1856B0C30")]
		private void BindRotation()
		{
		}

		// Token: 0x06000BD4 RID: 3028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BD4")]
		[Address(RVA = "0x56B0DD0", Offset = "0x56AF9D0", VA = "0x1856B0DD0")]
		private void BindTrackingState()
		{
		}

		// Token: 0x06000BD5 RID: 3029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BD5")]
		[Address(RVA = "0x56B19C0", Offset = "0x56B05C0", VA = "0x1856B19C0")]
		private void UnbindPosition()
		{
		}

		// Token: 0x06000BD6 RID: 3030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BD6")]
		[Address(RVA = "0x56B1B00", Offset = "0x56B0700", VA = "0x1856B1B00")]
		private void UnbindRotation()
		{
		}

		// Token: 0x06000BD7 RID: 3031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BD7")]
		[Address(RVA = "0x56B1C40", Offset = "0x56B0840", VA = "0x1856B1C40")]
		private void UnbindTrackingState()
		{
		}

		// Token: 0x06000BD8 RID: 3032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BD8")]
		[Address(RVA = "0x56B1280", Offset = "0x56AFE80", VA = "0x1856B1280")]
		private void OnPositionPerformed(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06000BD9 RID: 3033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BD9")]
		[Address(RVA = "0x56B1230", Offset = "0x56AFE30", VA = "0x1856B1230")]
		private void OnPositionCanceled(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06000BDA RID: 3034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BDA")]
		[Address(RVA = "0x56B1320", Offset = "0x56AFF20", VA = "0x1856B1320")]
		private void OnRotationPerformed(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06000BDB RID: 3035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BDB")]
		[Address(RVA = "0x56B12E0", Offset = "0x56AFEE0", VA = "0x1856B12E0")]
		private void OnRotationCanceled(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06000BDC RID: 3036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BDC")]
		[Address(RVA = "0x56B1390", Offset = "0x56AFF90", VA = "0x1856B1390")]
		private void OnTrackingStatePerformed(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06000BDD RID: 3037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BDD")]
		[Address(RVA = "0x56B1380", Offset = "0x56AFF80", VA = "0x1856B1380")]
		private void OnTrackingStateCanceled(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06000BDE RID: 3038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BDE")]
		[Address(RVA = "0x56B1610", Offset = "0x56B0210", VA = "0x1856B1610")]
		protected void Reset()
		{
		}

		// Token: 0x06000BDF RID: 3039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BDF")]
		[Address(RVA = "0x56B09E0", Offset = "0x56AF5E0", VA = "0x1856B09E0", Slot = "6")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06000BE0 RID: 3040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BE0")]
		[Address(RVA = "0x56B1170", Offset = "0x56AFD70", VA = "0x1856B1170")]
		protected void OnEnable()
		{
		}

		// Token: 0x06000BE1 RID: 3041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BE1")]
		[Address(RVA = "0x56B10B0", Offset = "0x56AFCB0", VA = "0x1856B10B0")]
		protected void OnDisable()
		{
		}

		// Token: 0x06000BE2 RID: 3042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BE2")]
		[Address(RVA = "0x56B1030", Offset = "0x56AFC30", VA = "0x1856B1030", Slot = "7")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x06000BE3 RID: 3043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BE3")]
		[Address(RVA = "0x56B1E50", Offset = "0x56B0A50", VA = "0x1856B1E50")]
		protected void UpdateCallback()
		{
		}

		// Token: 0x06000BE4 RID: 3044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BE4")]
		[Address(RVA = "0x56B14A0", Offset = "0x56B00A0", VA = "0x1856B14A0")]
		private void ReadTrackingState()
		{
		}

		// Token: 0x06000BE5 RID: 3045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BE5")]
		[Address(RVA = "0x56B13E0", Offset = "0x56AFFE0", VA = "0x1856B13E0", Slot = "8")]
		protected virtual void OnUpdate()
		{
		}

		// Token: 0x06000BE6 RID: 3046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BE6")]
		[Address(RVA = "0x56B0FE0", Offset = "0x56AFBE0", VA = "0x1856B0FE0", Slot = "9")]
		protected virtual void OnBeforeRender()
		{
		}

		// Token: 0x06000BE7 RID: 3047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BE7")]
		[Address(RVA = "0x56B1420", Offset = "0x56B0020", VA = "0x1856B1420", Slot = "10")]
		protected virtual void PerformUpdate()
		{
		}

		// Token: 0x06000BE8 RID: 3048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BE8")]
		[Address(RVA = "0x56B1850", Offset = "0x56B0450", VA = "0x1856B1850", Slot = "11")]
		protected virtual void SetLocalTransform(Vector3 newPosition, Quaternion newRotation)
		{
		}

		// Token: 0x06000BE9 RID: 3049 RVA: 0x00005C10 File Offset: 0x00003E10
		[Token(Token = "0x6000BE9")]
		[Address(RVA = "0x56B0F70", Offset = "0x56AFB70", VA = "0x1856B0F70")]
		private bool HasStereoCamera(out Camera cameraComponent)
		{
			return default(bool);
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000BEA RID: 3050 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000BEB RID: 3051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000313")]
		public InputAction positionAction
		{
			[Token(Token = "0x6000BEA")]
			[Address(RVA = "0x56B21A0", Offset = "0x56B0DA0", VA = "0x1856B21A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BEB")]
			[Address(RVA = "0x56B21C0", Offset = "0x56B0DC0", VA = "0x1856B21C0")]
			set
			{
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000BEC RID: 3052 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000BED RID: 3053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000314")]
		public InputAction rotationAction
		{
			[Token(Token = "0x6000BEC")]
			[Address(RVA = "0x56B21B0", Offset = "0x56B0DB0", VA = "0x1856B21B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BED")]
			[Address(RVA = "0x56B22D0", Offset = "0x56B0ED0", VA = "0x1856B22D0")]
			set
			{
			}
		}

		// Token: 0x06000BEE RID: 3054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BEE")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "4")]
		private void OnBeforeSerialize()
		{
		}

		// Token: 0x06000BEF RID: 3055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BEF")]
		[Address(RVA = "0x56B1D80", Offset = "0x56B0980", VA = "0x1856B1D80", Slot = "5")]
		private void OnAfterDeserialize()
		{
		}

		// Token: 0x06000BF0 RID: 3056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BF0")]
		[Address(RVA = "0x56B2100", Offset = "0x56B0D00", VA = "0x1856B2100")]
		public TrackedPoseDriver()
		{
		}

		// Token: 0x0400051D RID: 1309
		[Token(Token = "0x400051D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Tooltip("Which Transform properties to update.")]
		private TrackedPoseDriver.TrackingType m_TrackingType;

		// Token: 0x0400051E RID: 1310
		[Token(Token = "0x400051E")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[Tooltip("Updates the Transform properties after these phases of Input System event processing.")]
		private TrackedPoseDriver.UpdateType m_UpdateType;

		// Token: 0x0400051F RID: 1311
		[Token(Token = "0x400051F")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("Ignore Tracking State and always treat the input pose as valid.")]
		[SerializeField]
		private bool m_IgnoreTrackingState;

		// Token: 0x04000520 RID: 1312
		[Token(Token = "0x4000520")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("The input action to read the position value of a tracked device. Must be a Vector 3 control type.")]
		[SerializeField]
		private InputActionProperty m_PositionInput;

		// Token: 0x04000521 RID: 1313
		[Token(Token = "0x4000521")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Tooltip("The input action to read the rotation value of a tracked device. Must be a Quaternion control type.")]
		private InputActionProperty m_RotationInput;

		// Token: 0x04000522 RID: 1314
		[Token(Token = "0x4000522")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Tooltip("The input action to read the tracking state value of a tracked device. Identifies if position and rotation have valid data. Must be an Integer control type.")]
		private InputActionProperty m_TrackingStateInput;

		// Token: 0x04000523 RID: 1315
		[Token(Token = "0x4000523")]
		[FieldOffset(Offset = "0x70")]
		private Vector3 m_CurrentPosition;

		// Token: 0x04000524 RID: 1316
		[Token(Token = "0x4000524")]
		[FieldOffset(Offset = "0x7C")]
		private Quaternion m_CurrentRotation;

		// Token: 0x04000525 RID: 1317
		[Token(Token = "0x4000525")]
		[FieldOffset(Offset = "0x8C")]
		private TrackedPoseDriver.TrackingStates m_CurrentTrackingState;

		// Token: 0x04000526 RID: 1318
		[Token(Token = "0x4000526")]
		[FieldOffset(Offset = "0x90")]
		private bool m_RotationBound;

		// Token: 0x04000527 RID: 1319
		[Token(Token = "0x4000527")]
		[FieldOffset(Offset = "0x91")]
		private bool m_PositionBound;

		// Token: 0x04000528 RID: 1320
		[Token(Token = "0x4000528")]
		[FieldOffset(Offset = "0x92")]
		private bool m_TrackingStateBound;

		// Token: 0x04000529 RID: 1321
		[Token(Token = "0x4000529")]
		[FieldOffset(Offset = "0x93")]
		private bool m_IsFirstUpdate;

		// Token: 0x0400052A RID: 1322
		[Token(Token = "0x400052A")]
		[FieldOffset(Offset = "0x98")]
		[Obsolete]
		[HideInInspector]
		[SerializeField]
		private InputAction m_PositionAction;

		// Token: 0x0400052B RID: 1323
		[Token(Token = "0x400052B")]
		[FieldOffset(Offset = "0xA0")]
		[Obsolete]
		[HideInInspector]
		[SerializeField]
		private InputAction m_RotationAction;

		// Token: 0x020000E0 RID: 224
		[Token(Token = "0x20000E0")]
		public enum TrackingType
		{
			// Token: 0x0400052D RID: 1325
			[Token(Token = "0x400052D")]
			RotationAndPosition,
			// Token: 0x0400052E RID: 1326
			[Token(Token = "0x400052E")]
			RotationOnly,
			// Token: 0x0400052F RID: 1327
			[Token(Token = "0x400052F")]
			PositionOnly
		}

		// Token: 0x020000E1 RID: 225
		[Token(Token = "0x20000E1")]
		[Flags]
		private enum TrackingStates
		{
			// Token: 0x04000531 RID: 1329
			[Token(Token = "0x4000531")]
			None = 0,
			// Token: 0x04000532 RID: 1330
			[Token(Token = "0x4000532")]
			Position = 1,
			// Token: 0x04000533 RID: 1331
			[Token(Token = "0x4000533")]
			Rotation = 2
		}

		// Token: 0x020000E2 RID: 226
		[Token(Token = "0x20000E2")]
		public enum UpdateType
		{
			// Token: 0x04000535 RID: 1333
			[Token(Token = "0x4000535")]
			UpdateAndBeforeRender,
			// Token: 0x04000536 RID: 1334
			[Token(Token = "0x4000536")]
			Update,
			// Token: 0x04000537 RID: 1335
			[Token(Token = "0x4000537")]
			BeforeRender
		}
	}
}
