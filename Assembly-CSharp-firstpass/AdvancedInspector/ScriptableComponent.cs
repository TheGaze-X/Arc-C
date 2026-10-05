using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace AdvancedInspector
{
	// Token: 0x0200004E RID: 78
	[Token(Token = "0x200004E")]
	public class ScriptableComponent : ScriptableObject
	{
		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600022F RID: 559 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000230 RID: 560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000088")]
		public ScriptableObject Owner
		{
			[Token(Token = "0x600022F")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000230")]
			[Address(RVA = "0x4F4B10", Offset = "0x4F3710", VA = "0x1804F4B10")]
			set
			{
			}
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000231")]
		[Address(RVA = "0x4EC000", Offset = "0x4EAC00", VA = "0x1804EC000", Slot = "4")]
		protected virtual void Reset()
		{
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000232")]
		[Address(RVA = "0x4F4700", Offset = "0x4F3300", VA = "0x1804F4700")]
		public void Erase()
		{
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000233")]
		[Address(RVA = "0x4F4A50", Offset = "0x4F3650", VA = "0x1804F4A50")]
		public ScriptableComponent Instantiate()
		{
			return null;
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000234")]
		[Address(RVA = "0x4F49A0", Offset = "0x4F35A0", VA = "0x1804F49A0")]
		public ScriptableComponent Instantiate(ScriptableObject owner)
		{
			return null;
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000235")]
		[Address(RVA = "0x4F42C0", Offset = "0x4F2EC0", VA = "0x1804F42C0")]
		private static object CopyObject(ScriptableObject owner, object original)
		{
			return null;
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000236")]
		[Address(RVA = "0x4F3DF0", Offset = "0x4F29F0", VA = "0x1804F3DF0")]
		private static IList CopyList(ScriptableObject owner, IList original)
		{
			return null;
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000237")]
		[Address(RVA = "0x4F3BE0", Offset = "0x4F27E0", VA = "0x1804F3BE0")]
		private static ScriptableComponent CopyComponent(ScriptableObject owner, ScriptableComponent original)
		{
			return null;
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000238")]
		[Address(RVA = "0x4F3A30", Offset = "0x4F2630", VA = "0x1804F3A30")]
		private static object CopyClass(ScriptableObject owner, object original)
		{
			return null;
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000239")]
		[Address(RVA = "0x4F4B00", Offset = "0x4F3700", VA = "0x1804F4B00")]
		public ScriptableComponent()
		{
		}

		// Token: 0x040000BD RID: 189
		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[HideInInspector]
		private ScriptableObject owner;
	}
}
