using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020001DD RID: 477
	[Token(Token = "0x20001DD")]
	public sealed class PointerMoveEvent : PointerEventBase<PointerMoveEvent>
	{
		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06000CDC RID: 3292 RVA: 0x00006840 File Offset: 0x00004A40
		// (set) Token: 0x06000CDD RID: 3293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002F4")]
		internal bool isHandledByDraggable
		{
			[Token(Token = "0x6000CDC")]
			[Address(RVA = "0x2213A10", Offset = "0x2212610", VA = "0x182213A10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000CDD")]
			[Address(RVA = "0x58E26D0", Offset = "0x58E12D0", VA = "0x1858E26D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000CDE RID: 3294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CDE")]
		[Address(RVA = "0x5AEAD30", Offset = "0x5AE9930", VA = "0x185AEAD30", Slot = "12")]
		protected override void Init()
		{
		}

		// Token: 0x06000CDF RID: 3295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CDF")]
		[Address(RVA = "0x5AEADD0", Offset = "0x5AE99D0", VA = "0x185AEADD0")]
		private void LocalInit()
		{
		}

		// Token: 0x06000CE0 RID: 3296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CE0")]
		[Address(RVA = "0x5AEB200", Offset = "0x5AE9E00", VA = "0x185AEB200")]
		public PointerMoveEvent()
		{
		}

		// Token: 0x06000CE1 RID: 3297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CE1")]
		[Address(RVA = "0x5AEAE40", Offset = "0x5AE9A40", VA = "0x185AEAE40", Slot = "9")]
		protected internal override void PostDispatch(IPanel panel)
		{
		}
	}
}
