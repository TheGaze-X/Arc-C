using System;
using Il2CppDummyDll;
using UnityEngine;

namespace FullInspector.Internal
{
	// Token: 0x02007CB2 RID: 31922
	[Token(Token = "0x2007CB2")]
	[Serializable]
	public class fiUnityObjectReference
	{
		// Token: 0x0602C967 RID: 182631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C967")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public fiUnityObjectReference()
		{
		}

		// Token: 0x0602C968 RID: 182632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C968")]
		[Address(RVA = "0x2885D90", Offset = "0x2884990", VA = "0x182885D90")]
		public fiUnityObjectReference(UnityEngine.Object target, bool tryRestore)
		{
		}

		// Token: 0x1700685E RID: 26718
		// (get) Token: 0x0602C969 RID: 182633 RVA: 0x000E1048 File Offset: 0x000DF248
		[Token(Token = "0x1700685E")]
		public bool IsValid
		{
			[Token(Token = "0x602C969")]
			[Address(RVA = "0x2885E50", Offset = "0x2884A50", VA = "0x182885E50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602C96A RID: 182634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C96A")]
		[Address(RVA = "0x2885D00", Offset = "0x2884900", VA = "0x182885D00")]
		private void TryRestoreFromInstanceId()
		{
		}

		// Token: 0x0602C96B RID: 182635 RVA: 0x000E1060 File Offset: 0x000DF260
		[Token(Token = "0x602C96B")]
		[Address(RVA = "0x2885C50", Offset = "0x2884850", VA = "0x182885C50", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0602C96C RID: 182636 RVA: 0x000E1078 File Offset: 0x000DF278
		[Token(Token = "0x602C96C")]
		[Address(RVA = "0x2885B80", Offset = "0x2884780", VA = "0x182885B80", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x040403DC RID: 263132
		[Token(Token = "0x40403DC")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private UnityEngine.Object _target;

		// Token: 0x040403DD RID: 263133
		[Token(Token = "0x40403DD")]
		[FieldOffset(Offset = "0x18")]
		public UnityEngine.Object Target;
	}
}
