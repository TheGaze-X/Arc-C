using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace CriWare
{
	// Token: 0x02000014 RID: 20
	[Token(Token = "0x2000014")]
	[AddComponentMenu("CRIWARE/CRI Atom Listener")]
	public class CriAtomListener : CriMonoBehaviour
	{
		// Token: 0x060000DA RID: 218 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x36CDFD0", Offset = "0x36CCBD0", VA = "0x1836CDFD0")]
		public static void CreateDummyNativeListener()
		{
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x36CE0C0", Offset = "0x36CCCC0", VA = "0x1836CE0C0")]
		public static void DestroyDummyNativeListener()
		{
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x060000DC RID: 220 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x060000DD RID: 221 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000014")]
		public CriAtomEx3dListener nativeListener
		{
			[Token(Token = "0x60000DC")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000DD")]
			[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060000DE RID: 222 RVA: 0x00002444 File Offset: 0x00000644
		// (set) Token: 0x060000DF RID: 223 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000015")]
		public bool isActive
		{
			[Token(Token = "0x60000DE")]
			[Address(RVA = "0x789390", Offset = "0x787F90", VA = "0x180789390")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000DF")]
			[Address(RVA = "0x36CE920", Offset = "0x36CD520", VA = "0x1836CE920")]
			set
			{
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x060000E1 RID: 225 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000016")]
		public CriAtomRegion region3d
		{
			[Token(Token = "0x60000E0")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E1")]
			[Address(RVA = "0x36CE990", Offset = "0x36CD590", VA = "0x1836CE990")]
			set
			{
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x17000017")]
		internal static CriAtomEx3dListener DummyNativeListener
		{
			[Token(Token = "0x60000E2")]
			[Address(RVA = "0x36CE8D0", Offset = "0x36CD4D0", VA = "0x1836CE8D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x36CDE20", Offset = "0x36CCA20", VA = "0x1836CDE20")]
		private void Awake()
		{
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x36CE450", Offset = "0x36CD050", VA = "0x1836CE450")]
		private void Start()
		{
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x36CE420", Offset = "0x36CD020", VA = "0x1836CE420", Slot = "4")]
		protected override void OnEnable()
		{
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x36CE2E0", Offset = "0x36CCEE0", VA = "0x1836CE2E0", Slot = "5")]
		protected override void OnDisable()
		{
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x36CE1B0", Offset = "0x36CCDB0", VA = "0x1836CE1B0")]
		private void OnDestroy()
		{
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
		public override void CriInternalUpdate()
		{
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x36CE0B0", Offset = "0x36CCCB0", VA = "0x1836CE0B0", Slot = "7")]
		public override void CriInternalLateUpdate()
		{
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x36CE4C0", Offset = "0x36CD0C0", VA = "0x1836CE4C0")]
		private void UpdatePosition()
		{
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x36CDAE0", Offset = "0x36CC6E0", VA = "0x1836CDAE0")]
		public void ActivateListener(bool exclusive = true)
		{
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x36CE8C0", Offset = "0x36CD4C0", VA = "0x1836CE8C0")]
		public CriAtomListener()
		{
		}

		// Token: 0x04000069 RID: 105
		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CriAtomRegion regionOnStart;

		// Token: 0x0400006A RID: 106
		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x38")]
		public bool activateListenerOnEnable;

		// Token: 0x0400006B RID: 107
		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x0")]
		private static List<CriAtomListener> listenersList;

		// Token: 0x0400006C RID: 108
		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x8")]
		private static CriAtomListener exclusiveListener;

		// Token: 0x0400006D RID: 109
		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x10")]
		private static CriAtomEx3dListener dummyNativeListener;

		// Token: 0x0400006E RID: 110
		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0x3C")]
		private Vector3 lastPosition;

		// Token: 0x0400006F RID: 111
		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x48")]
		private CriAtomRegion currentRegion;

		// Token: 0x04000070 RID: 112
		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x50")]
		private bool _isActive;
	}
}
