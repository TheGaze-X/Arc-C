using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sirenix.Utilities
{
	// Token: 0x02000069 RID: 105
	[Token(Token = "0x2000069")]
	public abstract class GlobalConfig<T> : ScriptableObject, IGlobalConfigEvents where T : GlobalConfig<T>, new()
	{
		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060002AF RID: 687 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x17000041")]
		public static GlobalConfigAttribute ConfigAttribute
		{
			[Token(Token = "0x60002AF")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060002B0 RID: 688 RVA: 0x0000311C File Offset: 0x0000131C
		[Token(Token = "0x17000042")]
		public static bool HasInstanceLoaded
		{
			[Token(Token = "0x60002B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060002B1 RID: 689 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x17000043")]
		public static T Instance
		{
			[Token(Token = "0x60002B1")]
			get
			{
				return null;
			}
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60002B2")]
		public static void LoadInstanceIfAssetExists()
		{
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60002B3")]
		public void OpenInEditor()
		{
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60002B4")]
		protected virtual void OnConfigInstanceFirstAccessed()
		{
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60002B5")]
		protected virtual void OnConfigAutoCreated()
		{
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60002B6")]
		private void OnConfigAutoCreated()
		{
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60002B7")]
		private void OnConfigInstanceFirstAccessed()
		{
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60002B8")]
		protected GlobalConfig()
		{
		}

		// Token: 0x0400019A RID: 410
		[Token(Token = "0x400019A")]
		[FieldOffset(Offset = "0x0")]
		private static GlobalConfigAttribute configAttribute;

		// Token: 0x0400019B RID: 411
		[Token(Token = "0x400019B")]
		[FieldOffset(Offset = "0x0")]
		private static T instance;
	}
}
