using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace AdvancedInspector
{
	// Token: 0x02000042 RID: 66
	[Token(Token = "0x2000042")]
	public abstract class ComponentMonoBehaviour : MonoBehaviour
	{
		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060001FA RID: 506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700007D")]
		public MonoBehaviour Owner
		{
			[Token(Token = "0x60001F9")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001FA")]
			[Address(RVA = "0x4EC020", Offset = "0x4EAC20", VA = "0x1804EC020")]
			set
			{
			}
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x4EC000", Offset = "0x4EAC00", VA = "0x1804EC000", Slot = "4")]
		protected virtual void Reset()
		{
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x4EBC30", Offset = "0x4EA830", VA = "0x1804EBC30")]
		public void Erase()
		{
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x4EBED0", Offset = "0x4EAAD0", VA = "0x1804EBED0")]
		public ComponentMonoBehaviour Instantiate()
		{
			return null;
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x4EBFC0", Offset = "0x4EABC0", VA = "0x1804EBFC0")]
		public ComponentMonoBehaviour Instantiate(MonoBehaviour owner)
		{
			return null;
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x4EBF00", Offset = "0x4EAB00", VA = "0x1804EBF00")]
		public ComponentMonoBehaviour Instantiate(GameObject go, MonoBehaviour owner)
		{
			return null;
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000200")]
		[Address(RVA = "0x4EB7D0", Offset = "0x4EA3D0", VA = "0x1804EB7D0")]
		private static object CopyObject(GameObject go, MonoBehaviour owner, object original)
		{
			return null;
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000201")]
		[Address(RVA = "0x4EB2E0", Offset = "0x4E9EE0", VA = "0x1804EB2E0")]
		private static IList CopyList(GameObject go, MonoBehaviour owner, IList original)
		{
			return null;
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000202")]
		[Address(RVA = "0x4EB070", Offset = "0x4E9C70", VA = "0x1804EB070")]
		private static ComponentMonoBehaviour CopyComponent(GameObject go, MonoBehaviour owner, ComponentMonoBehaviour original)
		{
			return null;
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000203")]
		[Address(RVA = "0x4EAEC0", Offset = "0x4E9AC0", VA = "0x1804EAEC0")]
		private static object CopyClass(GameObject go, MonoBehaviour owner, object original)
		{
			return null;
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000204")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		protected ComponentMonoBehaviour()
		{
		}

		// Token: 0x04000099 RID: 153
		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x18")]
		[HideInInspector]
		[SerializeField]
		private MonoBehaviour owner;
	}
}
