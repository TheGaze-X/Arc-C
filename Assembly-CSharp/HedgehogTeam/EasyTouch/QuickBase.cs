using System;
using Il2CppDummyDll;
using UnityEngine;

namespace HedgehogTeam.EasyTouch
{
	// Token: 0x020001EF RID: 495
	[Token(Token = "0x20001EF")]
	public class QuickBase : MonoBehaviour
	{
		// Token: 0x060008C6 RID: 2246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008C6")]
		[Address(RVA = "0x252FFE0", Offset = "0x252EBE0", VA = "0x18252FFE0")]
		private void Awake()
		{
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008C7")]
		[Address(RVA = "0x2530A20", Offset = "0x252F620", VA = "0x182530A20", Slot = "4")]
		public virtual void Start()
		{
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008C8")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "5")]
		public virtual void OnEnable()
		{
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008C9")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
		public virtual void OnDisable()
		{
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x00004050 File Offset: 0x00002250
		[Token(Token = "0x60008CA")]
		[Address(RVA = "0x2530900", Offset = "0x252F500", VA = "0x182530900")]
		protected Vector3 GetInfluencedAxis()
		{
			return default(Vector3);
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008CB")]
		[Address(RVA = "0x2530340", Offset = "0x252EF40", VA = "0x182530340")]
		protected void DoDirectAction(float value)
		{
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008CC")]
		[Address(RVA = "0x2530850", Offset = "0x252F450", VA = "0x182530850")]
		public void EnabledQuickComponent(string quickActionName)
		{
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008CD")]
		[Address(RVA = "0x2530290", Offset = "0x252EE90", VA = "0x182530290")]
		public void DisabledQuickComponent(string quickActionName)
		{
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008CE")]
		[Address(RVA = "0x25300F0", Offset = "0x252ECF0", VA = "0x1825300F0")]
		public void DisabledAllSwipeExcepted(string quickActionName)
		{
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008CF")]
		[Address(RVA = "0x2530F90", Offset = "0x252FB90", VA = "0x182530F90")]
		public QuickBase()
		{
		}

		// Token: 0x04000AF1 RID: 2801
		[Token(Token = "0x4000AF1")]
		[FieldOffset(Offset = "0x18")]
		public string quickActionName;

		// Token: 0x04000AF2 RID: 2802
		[Token(Token = "0x4000AF2")]
		[FieldOffset(Offset = "0x20")]
		public bool isMultiTouch;

		// Token: 0x04000AF3 RID: 2803
		[Token(Token = "0x4000AF3")]
		[FieldOffset(Offset = "0x21")]
		public bool is2Finger;

		// Token: 0x04000AF4 RID: 2804
		[Token(Token = "0x4000AF4")]
		[FieldOffset(Offset = "0x22")]
		public bool isOnTouch;

		// Token: 0x04000AF5 RID: 2805
		[Token(Token = "0x4000AF5")]
		[FieldOffset(Offset = "0x23")]
		public bool enablePickOverUI;

		// Token: 0x04000AF6 RID: 2806
		[Token(Token = "0x4000AF6")]
		[FieldOffset(Offset = "0x24")]
		public bool resetPhysic;

		// Token: 0x04000AF7 RID: 2807
		[Token(Token = "0x4000AF7")]
		[FieldOffset(Offset = "0x28")]
		public QuickBase.DirectAction directAction;

		// Token: 0x04000AF8 RID: 2808
		[Token(Token = "0x4000AF8")]
		[FieldOffset(Offset = "0x2C")]
		public QuickBase.AffectedAxesAction axesAction;

		// Token: 0x04000AF9 RID: 2809
		[Token(Token = "0x4000AF9")]
		[FieldOffset(Offset = "0x30")]
		public float sensibility;

		// Token: 0x04000AFA RID: 2810
		[Token(Token = "0x4000AFA")]
		[FieldOffset(Offset = "0x38")]
		public CharacterController directCharacterController;

		// Token: 0x04000AFB RID: 2811
		[Token(Token = "0x4000AFB")]
		[FieldOffset(Offset = "0x40")]
		public bool inverseAxisValue;

		// Token: 0x04000AFC RID: 2812
		[Token(Token = "0x4000AFC")]
		[FieldOffset(Offset = "0x48")]
		protected Rigidbody cachedRigidBody;

		// Token: 0x04000AFD RID: 2813
		[Token(Token = "0x4000AFD")]
		[FieldOffset(Offset = "0x50")]
		protected bool isKinematic;

		// Token: 0x04000AFE RID: 2814
		[Token(Token = "0x4000AFE")]
		[FieldOffset(Offset = "0x58")]
		protected Rigidbody2D cachedRigidBody2D;

		// Token: 0x04000AFF RID: 2815
		[Token(Token = "0x4000AFF")]
		[FieldOffset(Offset = "0x60")]
		protected bool isKinematic2D;

		// Token: 0x04000B00 RID: 2816
		[Token(Token = "0x4000B00")]
		[FieldOffset(Offset = "0x64")]
		protected QuickBase.GameObjectType realType;

		// Token: 0x04000B01 RID: 2817
		[Token(Token = "0x4000B01")]
		[FieldOffset(Offset = "0x68")]
		protected int fingerIndex;

		// Token: 0x020001F0 RID: 496
		[Token(Token = "0x20001F0")]
		protected enum GameObjectType
		{
			// Token: 0x04000B03 RID: 2819
			[Token(Token = "0x4000B03")]
			Auto,
			// Token: 0x04000B04 RID: 2820
			[Token(Token = "0x4000B04")]
			Obj_3D,
			// Token: 0x04000B05 RID: 2821
			[Token(Token = "0x4000B05")]
			Obj_2D,
			// Token: 0x04000B06 RID: 2822
			[Token(Token = "0x4000B06")]
			UI
		}

		// Token: 0x020001F1 RID: 497
		[Token(Token = "0x20001F1")]
		public enum DirectAction
		{
			// Token: 0x04000B08 RID: 2824
			[Token(Token = "0x4000B08")]
			None,
			// Token: 0x04000B09 RID: 2825
			[Token(Token = "0x4000B09")]
			Rotate,
			// Token: 0x04000B0A RID: 2826
			[Token(Token = "0x4000B0A")]
			RotateLocal,
			// Token: 0x04000B0B RID: 2827
			[Token(Token = "0x4000B0B")]
			Translate,
			// Token: 0x04000B0C RID: 2828
			[Token(Token = "0x4000B0C")]
			TranslateLocal,
			// Token: 0x04000B0D RID: 2829
			[Token(Token = "0x4000B0D")]
			Scale
		}

		// Token: 0x020001F2 RID: 498
		[Token(Token = "0x20001F2")]
		public enum AffectedAxesAction
		{
			// Token: 0x04000B0F RID: 2831
			[Token(Token = "0x4000B0F")]
			X,
			// Token: 0x04000B10 RID: 2832
			[Token(Token = "0x4000B10")]
			Y,
			// Token: 0x04000B11 RID: 2833
			[Token(Token = "0x4000B11")]
			Z,
			// Token: 0x04000B12 RID: 2834
			[Token(Token = "0x4000B12")]
			XY,
			// Token: 0x04000B13 RID: 2835
			[Token(Token = "0x4000B13")]
			XZ,
			// Token: 0x04000B14 RID: 2836
			[Token(Token = "0x4000B14")]
			YZ,
			// Token: 0x04000B15 RID: 2837
			[Token(Token = "0x4000B15")]
			XYZ
		}
	}
}
