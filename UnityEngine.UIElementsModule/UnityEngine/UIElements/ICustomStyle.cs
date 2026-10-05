using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x0200021F RID: 543
	[Token(Token = "0x200021F")]
	public interface ICustomStyle
	{
		// Token: 0x06000EF1 RID: 3825
		[Token(Token = "0x6000EF1")]
		bool TryGetValue(CustomStyleProperty<float> property, out float value);

		// Token: 0x06000EF2 RID: 3826
		[Token(Token = "0x6000EF2")]
		bool TryGetValue(CustomStyleProperty<int> property, out int value);

		// Token: 0x06000EF3 RID: 3827
		[Token(Token = "0x6000EF3")]
		bool TryGetValue(CustomStyleProperty<Color> property, out Color value);

		// Token: 0x06000EF4 RID: 3828
		[Token(Token = "0x6000EF4")]
		bool TryGetValue(CustomStyleProperty<Texture2D> property, out Texture2D value);

		// Token: 0x06000EF5 RID: 3829
		[Token(Token = "0x6000EF5")]
		bool TryGetValue(CustomStyleProperty<Sprite> property, out Sprite value);

		// Token: 0x06000EF6 RID: 3830
		[Token(Token = "0x6000EF6")]
		bool TryGetValue(CustomStyleProperty<VectorImage> property, out VectorImage value);

		// Token: 0x06000EF7 RID: 3831
		[Token(Token = "0x6000EF7")]
		bool TryGetValue(CustomStyleProperty<string> property, out string value);
	}
}
