using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000030 RID: 48
[Token(Token = "0x2000030")]
[Serializable]
public class ETCAxis
{
	// Token: 0x1700001E RID: 30
	// (get) Token: 0x060000BC RID: 188 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060000BD RID: 189 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700001E")]
	public Transform directTransform
	{
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x4FB2F0", Offset = "0x4F9EF0", VA = "0x1804FB2F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x4FB300", Offset = "0x4F9F00", VA = "0x1804FB300")]
		set
		{
		}
	}

	// Token: 0x060000BE RID: 190 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x4FB200", Offset = "0x4F9E00", VA = "0x1804FB200")]
	public ETCAxis(string axisName)
	{
	}

	// Token: 0x060000BF RID: 191 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x4FAB40", Offset = "0x4F9740", VA = "0x1804FAB40")]
	public void InitAxis()
	{
	}

	// Token: 0x060000C0 RID: 192 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x4FACA0", Offset = "0x4F98A0", VA = "0x1804FACA0")]
	public void UpdateAxis(float realValue, bool isOnDrag, ETCBase.ControlType type, bool deltaTime = true)
	{
	}

	// Token: 0x060000C1 RID: 193 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x4FB020", Offset = "0x4F9C20", VA = "0x1804FB020")]
	public void UpdateButton()
	{
	}

	// Token: 0x060000C2 RID: 194 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x4FAC70", Offset = "0x4F9870", VA = "0x1804FAC70")]
	public void ResetAxis()
	{
	}

	// Token: 0x060000C3 RID: 195 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x4F9B50", Offset = "0x4F8750", VA = "0x1804F9B50")]
	public void DoDirectAction()
	{
	}

	// Token: 0x060000C4 RID: 196 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x4FA620", Offset = "0x4F9220", VA = "0x1804FA620")]
	public void DoGravity()
	{
	}

	// Token: 0x060000C5 RID: 197 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x4F9280", Offset = "0x4F7E80", VA = "0x1804F9280")]
	private void ComputAxisValue(float realValue, ETCBase.ControlType type, bool isOnDrag, bool deltaTime)
	{
	}

	// Token: 0x060000C6 RID: 198 RVA: 0x000023A0 File Offset: 0x000005A0
	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x4FAA20", Offset = "0x4F9620", VA = "0x1804FAA20")]
	private Vector3 GetInfluencedAxis()
	{
		return default(Vector3);
	}

	// Token: 0x060000C7 RID: 199 RVA: 0x000023B8 File Offset: 0x000005B8
	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x4FA790", Offset = "0x4F9390", VA = "0x1804FA790")]
	private float GetAngle()
	{
		return 0f;
	}

	// Token: 0x060000C8 RID: 200 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x4F9570", Offset = "0x4F8170", VA = "0x1804F9570")]
	private void DoAutoStabilisation()
	{
	}

	// Token: 0x060000C9 RID: 201 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x4F93B0", Offset = "0x4F7FB0", VA = "0x1804F93B0")]
	private void DoAngleLimitation()
	{
	}

	// Token: 0x060000CA RID: 202 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x4FAC00", Offset = "0x4F9800", VA = "0x1804FAC00")]
	public void InitDeadCurve()
	{
	}

	// Token: 0x040000B1 RID: 177
	[Token(Token = "0x40000B1")]
	[FieldOffset(Offset = "0x10")]
	public string name;

	// Token: 0x040000B2 RID: 178
	[Token(Token = "0x40000B2")]
	[FieldOffset(Offset = "0x18")]
	public bool autoLinkTagPlayer;

	// Token: 0x040000B3 RID: 179
	[Token(Token = "0x40000B3")]
	[FieldOffset(Offset = "0x20")]
	public string autoTag;

	// Token: 0x040000B4 RID: 180
	[Token(Token = "0x40000B4")]
	[FieldOffset(Offset = "0x28")]
	public GameObject player;

	// Token: 0x040000B5 RID: 181
	[Token(Token = "0x40000B5")]
	[FieldOffset(Offset = "0x30")]
	public bool enable;

	// Token: 0x040000B6 RID: 182
	[Token(Token = "0x40000B6")]
	[FieldOffset(Offset = "0x31")]
	public bool invertedAxis;

	// Token: 0x040000B7 RID: 183
	[Token(Token = "0x40000B7")]
	[FieldOffset(Offset = "0x34")]
	public float speed;

	// Token: 0x040000B8 RID: 184
	[Token(Token = "0x40000B8")]
	[FieldOffset(Offset = "0x38")]
	public float deadValue;

	// Token: 0x040000B9 RID: 185
	[Token(Token = "0x40000B9")]
	[FieldOffset(Offset = "0x3C")]
	public ETCAxis.AxisValueMethod valueMethod;

	// Token: 0x040000BA RID: 186
	[Token(Token = "0x40000BA")]
	[FieldOffset(Offset = "0x40")]
	public AnimationCurve curveValue;

	// Token: 0x040000BB RID: 187
	[Token(Token = "0x40000BB")]
	[FieldOffset(Offset = "0x48")]
	public bool isEnertia;

	// Token: 0x040000BC RID: 188
	[Token(Token = "0x40000BC")]
	[FieldOffset(Offset = "0x4C")]
	public float inertia;

	// Token: 0x040000BD RID: 189
	[Token(Token = "0x40000BD")]
	[FieldOffset(Offset = "0x50")]
	public float inertiaThreshold;

	// Token: 0x040000BE RID: 190
	[Token(Token = "0x40000BE")]
	[FieldOffset(Offset = "0x54")]
	public bool isAutoStab;

	// Token: 0x040000BF RID: 191
	[Token(Token = "0x40000BF")]
	[FieldOffset(Offset = "0x58")]
	public float autoStabThreshold;

	// Token: 0x040000C0 RID: 192
	[Token(Token = "0x40000C0")]
	[FieldOffset(Offset = "0x5C")]
	public float autoStabSpeed;

	// Token: 0x040000C1 RID: 193
	[Token(Token = "0x40000C1")]
	[FieldOffset(Offset = "0x60")]
	private float startAngle;

	// Token: 0x040000C2 RID: 194
	[Token(Token = "0x40000C2")]
	[FieldOffset(Offset = "0x64")]
	public bool isClampRotation;

	// Token: 0x040000C3 RID: 195
	[Token(Token = "0x40000C3")]
	[FieldOffset(Offset = "0x68")]
	public float maxAngle;

	// Token: 0x040000C4 RID: 196
	[Token(Token = "0x40000C4")]
	[FieldOffset(Offset = "0x6C")]
	public float minAngle;

	// Token: 0x040000C5 RID: 197
	[Token(Token = "0x40000C5")]
	[FieldOffset(Offset = "0x70")]
	public bool isValueOverTime;

	// Token: 0x040000C6 RID: 198
	[Token(Token = "0x40000C6")]
	[FieldOffset(Offset = "0x74")]
	public float overTimeStep;

	// Token: 0x040000C7 RID: 199
	[Token(Token = "0x40000C7")]
	[FieldOffset(Offset = "0x78")]
	public float maxOverTimeValue;

	// Token: 0x040000C8 RID: 200
	[Token(Token = "0x40000C8")]
	[FieldOffset(Offset = "0x7C")]
	public float axisValue;

	// Token: 0x040000C9 RID: 201
	[Token(Token = "0x40000C9")]
	[FieldOffset(Offset = "0x80")]
	public float axisSpeedValue;

	// Token: 0x040000CA RID: 202
	[Token(Token = "0x40000CA")]
	[FieldOffset(Offset = "0x84")]
	public float axisThreshold;

	// Token: 0x040000CB RID: 203
	[Token(Token = "0x40000CB")]
	[FieldOffset(Offset = "0x88")]
	public bool isLockinJump;

	// Token: 0x040000CC RID: 204
	[Token(Token = "0x40000CC")]
	[FieldOffset(Offset = "0x8C")]
	private Vector3 lastMove;

	// Token: 0x040000CD RID: 205
	[Token(Token = "0x40000CD")]
	[FieldOffset(Offset = "0x98")]
	public ETCAxis.AxisState axisState;

	// Token: 0x040000CE RID: 206
	[Token(Token = "0x40000CE")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private Transform _directTransform;

	// Token: 0x040000CF RID: 207
	[Token(Token = "0x40000CF")]
	[FieldOffset(Offset = "0xA8")]
	public ETCAxis.DirectAction directAction;

	// Token: 0x040000D0 RID: 208
	[Token(Token = "0x40000D0")]
	[FieldOffset(Offset = "0xAC")]
	public ETCAxis.AxisInfluenced axisInfluenced;

	// Token: 0x040000D1 RID: 209
	[Token(Token = "0x40000D1")]
	[FieldOffset(Offset = "0xB0")]
	public ETCAxis.ActionOn actionOn;

	// Token: 0x040000D2 RID: 210
	[Token(Token = "0x40000D2")]
	[FieldOffset(Offset = "0xB8")]
	public CharacterController directCharacterController;

	// Token: 0x040000D3 RID: 211
	[Token(Token = "0x40000D3")]
	[FieldOffset(Offset = "0xC0")]
	public Rigidbody directRigidBody;

	// Token: 0x040000D4 RID: 212
	[Token(Token = "0x40000D4")]
	[FieldOffset(Offset = "0xC8")]
	public float gravity;

	// Token: 0x040000D5 RID: 213
	[Token(Token = "0x40000D5")]
	[FieldOffset(Offset = "0xCC")]
	public float currentGravity;

	// Token: 0x040000D6 RID: 214
	[Token(Token = "0x40000D6")]
	[FieldOffset(Offset = "0xD0")]
	public bool isJump;

	// Token: 0x040000D7 RID: 215
	[Token(Token = "0x40000D7")]
	[FieldOffset(Offset = "0xD8")]
	public string unityAxis;

	// Token: 0x040000D8 RID: 216
	[Token(Token = "0x40000D8")]
	[FieldOffset(Offset = "0xE0")]
	public bool showGeneralInspector;

	// Token: 0x040000D9 RID: 217
	[Token(Token = "0x40000D9")]
	[FieldOffset(Offset = "0xE1")]
	public bool showDirectInspector;

	// Token: 0x040000DA RID: 218
	[Token(Token = "0x40000DA")]
	[FieldOffset(Offset = "0xE2")]
	public bool showInertiaInspector;

	// Token: 0x040000DB RID: 219
	[Token(Token = "0x40000DB")]
	[FieldOffset(Offset = "0xE3")]
	public bool showSimulatinInspector;

	// Token: 0x02000031 RID: 49
	[Token(Token = "0x2000031")]
	public enum DirectAction
	{
		// Token: 0x040000DD RID: 221
		[Token(Token = "0x40000DD")]
		Rotate,
		// Token: 0x040000DE RID: 222
		[Token(Token = "0x40000DE")]
		RotateLocal,
		// Token: 0x040000DF RID: 223
		[Token(Token = "0x40000DF")]
		Translate,
		// Token: 0x040000E0 RID: 224
		[Token(Token = "0x40000E0")]
		TranslateLocal,
		// Token: 0x040000E1 RID: 225
		[Token(Token = "0x40000E1")]
		Scale,
		// Token: 0x040000E2 RID: 226
		[Token(Token = "0x40000E2")]
		Force,
		// Token: 0x040000E3 RID: 227
		[Token(Token = "0x40000E3")]
		RelativeForce,
		// Token: 0x040000E4 RID: 228
		[Token(Token = "0x40000E4")]
		Torque,
		// Token: 0x040000E5 RID: 229
		[Token(Token = "0x40000E5")]
		RelativeTorque,
		// Token: 0x040000E6 RID: 230
		[Token(Token = "0x40000E6")]
		Jump
	}

	// Token: 0x02000032 RID: 50
	[Token(Token = "0x2000032")]
	public enum AxisInfluenced
	{
		// Token: 0x040000E8 RID: 232
		[Token(Token = "0x40000E8")]
		X,
		// Token: 0x040000E9 RID: 233
		[Token(Token = "0x40000E9")]
		Y,
		// Token: 0x040000EA RID: 234
		[Token(Token = "0x40000EA")]
		Z
	}

	// Token: 0x02000033 RID: 51
	[Token(Token = "0x2000033")]
	public enum AxisValueMethod
	{
		// Token: 0x040000EC RID: 236
		[Token(Token = "0x40000EC")]
		Classical,
		// Token: 0x040000ED RID: 237
		[Token(Token = "0x40000ED")]
		Curve
	}

	// Token: 0x02000034 RID: 52
	[Token(Token = "0x2000034")]
	public enum AxisState
	{
		// Token: 0x040000EF RID: 239
		[Token(Token = "0x40000EF")]
		None,
		// Token: 0x040000F0 RID: 240
		[Token(Token = "0x40000F0")]
		Down,
		// Token: 0x040000F1 RID: 241
		[Token(Token = "0x40000F1")]
		Press,
		// Token: 0x040000F2 RID: 242
		[Token(Token = "0x40000F2")]
		Up,
		// Token: 0x040000F3 RID: 243
		[Token(Token = "0x40000F3")]
		DownUp,
		// Token: 0x040000F4 RID: 244
		[Token(Token = "0x40000F4")]
		DownDown,
		// Token: 0x040000F5 RID: 245
		[Token(Token = "0x40000F5")]
		DownLeft,
		// Token: 0x040000F6 RID: 246
		[Token(Token = "0x40000F6")]
		DownRight,
		// Token: 0x040000F7 RID: 247
		[Token(Token = "0x40000F7")]
		PressUp,
		// Token: 0x040000F8 RID: 248
		[Token(Token = "0x40000F8")]
		PressDown,
		// Token: 0x040000F9 RID: 249
		[Token(Token = "0x40000F9")]
		PressLeft,
		// Token: 0x040000FA RID: 250
		[Token(Token = "0x40000FA")]
		PressRight
	}

	// Token: 0x02000035 RID: 53
	[Token(Token = "0x2000035")]
	public enum ActionOn
	{
		// Token: 0x040000FC RID: 252
		[Token(Token = "0x40000FC")]
		Down,
		// Token: 0x040000FD RID: 253
		[Token(Token = "0x40000FD")]
		Press
	}
}
