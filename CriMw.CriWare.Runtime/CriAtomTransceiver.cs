using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace CriWare
{
	// Token: 0x0200001F RID: 31
	[Token(Token = "0x200001F")]
	[DisallowMultipleComponent]
	[AddComponentMenu("CRIWARE/CRI Atom Transceiver")]
	public class CriAtomTransceiver : CriMonoBehaviour
	{
		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600016F RID: 367 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x06000170 RID: 368 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000035")]
		public CriAtomEx3dTransceiver transceiverHn
		{
			[Token(Token = "0x600016F")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000170")]
			[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000171 RID: 369 RVA: 0x0000269C File Offset: 0x0000089C
		// (set) Token: 0x06000172 RID: 370 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000036")]
		public Vector3 inputPos
		{
			[Token(Token = "0x6000171")]
			[Address(RVA = "0x34BF5A0", Offset = "0x34BE1A0", VA = "0x1834BF5A0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000172")]
			[Address(RVA = "0x36D6A20", Offset = "0x36D5620", VA = "0x1836D6A20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000173 RID: 371 RVA: 0x000026B4 File Offset: 0x000008B4
		// (set) Token: 0x06000174 RID: 372 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000037")]
		public Vector3 inputFront
		{
			[Token(Token = "0x6000173")]
			[Address(RVA = "0x34BF5C0", Offset = "0x34BE1C0", VA = "0x1834BF5C0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000174")]
			[Address(RVA = "0x36D6A10", Offset = "0x36D5610", VA = "0x1836D6A10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000175 RID: 373 RVA: 0x000026CC File Offset: 0x000008CC
		// (set) Token: 0x06000176 RID: 374 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000038")]
		public Vector3 inputUp
		{
			[Token(Token = "0x6000175")]
			[Address(RVA = "0x36D69F0", Offset = "0x36D55F0", VA = "0x1836D69F0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000176")]
			[Address(RVA = "0x36D6A30", Offset = "0x36D5630", VA = "0x1836D6A30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000177 RID: 375 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x06000178 RID: 376 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000039")]
		public CriAtomRegion region3d
		{
			[Token(Token = "0x6000177")]
			[Address(RVA = "0x2569110", Offset = "0x2567D10", VA = "0x182569110")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000178")]
			[Address(RVA = "0x36D6A40", Offset = "0x36D5640", VA = "0x1836D6A40")]
			set
			{
			}
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000179")]
		[Address(RVA = "0x5D55A0", Offset = "0x5D41A0", VA = "0x1805D55A0")]
		private void Awake()
		{
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600017A")]
		[Address(RVA = "0x36D66F0", Offset = "0x36D52F0", VA = "0x1836D66F0")]
		private void Start()
		{
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600017B")]
		[Address(RVA = "0x36D32A0", Offset = "0x36D1EA0", VA = "0x1836D32A0", Slot = "4")]
		protected override void OnEnable()
		{
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600017C")]
		[Address(RVA = "0x36D3260", Offset = "0x36D1E60", VA = "0x1836D3260")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600017D")]
		[Address(RVA = "0x36D6550", Offset = "0x36D5150", VA = "0x1836D6550", Slot = "8")]
		protected virtual void InternalInitialize()
		{
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600017E")]
		[Address(RVA = "0x36D64A0", Offset = "0x36D50A0", VA = "0x1836D64A0", Slot = "9")]
		protected virtual void InternalFinalize()
		{
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600017F")]
		[Address(RVA = "0x36D6420", Offset = "0x36D5020", VA = "0x1836D6420", Slot = "10")]
		protected virtual void InitializeParameters()
		{
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000180")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
		public override void CriInternalUpdate()
		{
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000181")]
		[Address(RVA = "0x36D6410", Offset = "0x36D5010", VA = "0x1836D6410", Slot = "7")]
		public override void CriInternalLateUpdate()
		{
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000182")]
		[Address(RVA = "0x36D5820", Offset = "0x36D4420", VA = "0x1836D5820")]
		private void ApplyCurrentPosition()
		{
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000183")]
		[Address(RVA = "0x36D5E20", Offset = "0x36D4A20", VA = "0x1836D5E20")]
		private void ApplyParameters()
		{
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000184")]
		[Address(RVA = "0x36D6760", Offset = "0x36D5360", VA = "0x1836D6760")]
		private void TrySetAisacControlId(string strId, CriAtomTransceiver.SetControlIdMethod callback)
		{
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000185")]
		[Address(RVA = "0x36D68A0", Offset = "0x36D54A0", VA = "0x1836D68A0")]
		public CriAtomTransceiver()
		{
		}

		// Token: 0x040000AB RID: 171
		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CriAtomRegion regionOnStart;

		// Token: 0x040000AC RID: 172
		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private bool useDedicatedInput;

		// Token: 0x040000AD RID: 173
		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject dedicatedInput;

		// Token: 0x040000AE RID: 174
		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x70")]
		[Range(0f, 1f)]
		[SerializeField]
		private float outputVolume;

		// Token: 0x040000AF RID: 175
		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private float directAudioRadius;

		// Token: 0x040000B0 RID: 176
		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private float crossFadeDistance;

		// Token: 0x040000B1 RID: 177
		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		[Range(0f, 360f)]
		private float coneInsideAngle;

		// Token: 0x040000B2 RID: 178
		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Range(0f, 360f)]
		private float coneOutsideAngle;

		// Token: 0x040000B3 RID: 179
		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		[Range(0f, 1f)]
		private float coneOutsideVolume;

		// Token: 0x040000B4 RID: 180
		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private float transceiverRadius;

		// Token: 0x040000B5 RID: 181
		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		private float interiorDistance;

		// Token: 0x040000B6 RID: 182
		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		public float minAttenuation;

		// Token: 0x040000B7 RID: 183
		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		public float maxAttenuation;

		// Token: 0x040000B8 RID: 184
		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private string globalAisacName;

		// Token: 0x040000B9 RID: 185
		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private float maxAngleAisacDelta;

		// Token: 0x040000BA RID: 186
		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private string distanceAisacControlId;

		// Token: 0x040000BB RID: 187
		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private string listenerAzimuthAisacControlId;

		// Token: 0x040000BC RID: 188
		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private string listenerElevationAisacControlId;

		// Token: 0x040000BD RID: 189
		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private string outputAzimuthAisacControlId;

		// Token: 0x040000BE RID: 190
		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private string outputElevationAisacControlId;

		// Token: 0x040000BF RID: 191
		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0xD0")]
		[NonSerialized]
		public bool inspectorAisacSettingFoldout;

		// Token: 0x040000C0 RID: 192
		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0xD1")]
		private bool isInitialized;

		// Token: 0x040000C1 RID: 193
		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0xD2")]
		private bool dedicatedInputNotSetWarned;

		// Token: 0x040000C2 RID: 194
		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0xD8")]
		private CriAtomRegion currentRegion;

		// Token: 0x02000020 RID: 32
		// (Invoke) Token: 0x06000187 RID: 391
		[Token(Token = "0x2000020")]
		private delegate void SetControlIdMethod(ushort id);
	}
}
