using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Building.Vault
{
	// Token: 0x02001A12 RID: 6674
	[Token(Token = "0x2001A12")]
	public class VMoveController : MonoBehaviour
	{
		// Token: 0x17001351 RID: 4945
		// (get) Token: 0x0600A745 RID: 42821 RVA: 0x00040B78 File Offset: 0x0003ED78
		[Token(Token = "0x17001351")]
		public bool isValid
		{
			[Token(Token = "0x600A745")]
			[Address(RVA = "0x3230390", Offset = "0x322EF90", VA = "0x183230390")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001352 RID: 4946
		// (get) Token: 0x0600A746 RID: 42822 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600A747 RID: 42823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001352")]
		private protected IMovable mover
		{
			[Token(Token = "0x600A746")]
			[Address(RVA = "0x51C280", Offset = "0x51AE80", VA = "0x18051C280")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x600A747")]
			[Address(RVA = "0x103EF20", Offset = "0x103DB20", VA = "0x18103EF20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001353 RID: 4947
		// (get) Token: 0x0600A748 RID: 42824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001353")]
		protected GridMap floorMap
		{
			[Token(Token = "0x600A748")]
			[Address(RVA = "0x32302B0", Offset = "0x322EEB0", VA = "0x1832302B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001354 RID: 4948
		// (get) Token: 0x0600A749 RID: 42825 RVA: 0x00040B90 File Offset: 0x0003ED90
		[Token(Token = "0x17001354")]
		protected float moveSpeed
		{
			[Token(Token = "0x600A749")]
			[Address(RVA = "0x32303E0", Offset = "0x322EFE0", VA = "0x1832303E0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600A74A RID: 42826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A74A")]
		[Address(RVA = "0x103EF20", Offset = "0x103DB20", VA = "0x18103EF20")]
		public void Init(IMovable mover)
		{
		}

		// Token: 0x0600A74B RID: 42827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A74B")]
		[Address(RVA = "0x322EB00", Offset = "0x322D700", VA = "0x18322EB00")]
		public void Begin(Path path)
		{
		}

		// Token: 0x0600A74C RID: 42828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A74C")]
		[Address(RVA = "0x322F7B0", Offset = "0x322E3B0", VA = "0x18322F7B0")]
		public void End()
		{
		}

		// Token: 0x0600A74D RID: 42829 RVA: 0x00040BA8 File Offset: 0x0003EDA8
		[Token(Token = "0x600A74D")]
		[Address(RVA = "0x322FAA0", Offset = "0x322E6A0", VA = "0x18322FAA0")]
		public bool Move(float deltaTime, out Vector2 direction)
		{
			return default(bool);
		}

		// Token: 0x0600A74E RID: 42830 RVA: 0x00040BC0 File Offset: 0x0003EDC0
		[Token(Token = "0x600A74E")]
		[Address(RVA = "0x322EBC0", Offset = "0x322D7C0", VA = "0x18322EBC0")]
		protected Vector2 CalculateMoveDelta(Vector2 direction, float deltaTime)
		{
			return default(Vector2);
		}

		// Token: 0x0600A74F RID: 42831 RVA: 0x00040BD8 File Offset: 0x0003EDD8
		[Token(Token = "0x600A74F")]
		[Address(RVA = "0x322F4A0", Offset = "0x322E0A0", VA = "0x18322F4A0")]
		protected Vector2 CalculateTotalForce(Vector2 direction)
		{
			return default(Vector2);
		}

		// Token: 0x0600A750 RID: 42832 RVA: 0x00040BF0 File Offset: 0x0003EDF0
		[Token(Token = "0x600A750")]
		[Address(RVA = "0x322ED40", Offset = "0x322D940", VA = "0x18322ED40")]
		protected Vector2 CalculateObstacleAvoidForce(Vector2 currentPos)
		{
			return default(Vector2);
		}

		// Token: 0x0600A751 RID: 42833 RVA: 0x00040C08 File Offset: 0x0003EE08
		[Token(Token = "0x600A751")]
		[Address(RVA = "0x322F860", Offset = "0x322E460", VA = "0x18322F860")]
		protected Vector2 GetNextDirection()
		{
			return default(Vector2);
		}

		// Token: 0x0600A752 RID: 42834 RVA: 0x00040C20 File Offset: 0x0003EE20
		[Token(Token = "0x600A752")]
		[Address(RVA = "0x322FFC0", Offset = "0x322EBC0", VA = "0x18322FFC0")]
		protected bool PredictReached(float stepDistance, out Vector2 direction)
		{
			return default(bool);
		}

		// Token: 0x0600A753 RID: 42835 RVA: 0x00040C38 File Offset: 0x0003EE38
		[Token(Token = "0x600A753")]
		[Address(RVA = "0x322F7C0", Offset = "0x322E3C0", VA = "0x18322F7C0")]
		protected Vector2 GetFinalPathPos()
		{
			return default(Vector2);
		}

		// Token: 0x0600A754 RID: 42836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A754")]
		[Address(RVA = "0x3230170", Offset = "0x322ED70", VA = "0x183230170")]
		private void _Reset()
		{
		}

		// Token: 0x0600A755 RID: 42837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A755")]
		[Address(RVA = "0x3230220", Offset = "0x322EE20", VA = "0x183230220")]
		public VMoveController()
		{
		}

		// Token: 0x04009F70 RID: 40816
		[Token(Token = "0x4009F70")]
		private const int OBSTACLE_AVOID_TICK_PERIOD = 3;

		// Token: 0x04009F71 RID: 40817
		[Token(Token = "0x4009F71")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _steeringFactor;

		// Token: 0x04009F72 RID: 40818
		[Token(Token = "0x4009F72")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _maxSteeringForce;

		// Token: 0x04009F73 RID: 40819
		[Token(Token = "0x4009F73")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _halfBodyWidth;

		// Token: 0x04009F74 RID: 40820
		[Token(Token = "0x4009F74")]
		[FieldOffset(Offset = "0x28")]
		private Path m_path;

		// Token: 0x04009F75 RID: 40821
		[Token(Token = "0x4009F75")]
		[FieldOffset(Offset = "0x38")]
		private int m_cursor;

		// Token: 0x04009F76 RID: 40822
		[Token(Token = "0x4009F76")]
		[FieldOffset(Offset = "0x3C")]
		private Vector2 m_finalPosOffset;

		// Token: 0x04009F77 RID: 40823
		[Token(Token = "0x4009F77")]
		[FieldOffset(Offset = "0x44")]
		private Vector2 m_lastObstacleAvoidForce;

		// Token: 0x04009F78 RID: 40824
		[Token(Token = "0x4009F78")]
		[FieldOffset(Offset = "0x4C")]
		private Vector2 m_lastVelocity;

		// Token: 0x04009F79 RID: 40825
		[Token(Token = "0x4009F79")]
		[FieldOffset(Offset = "0x58")]
		private PeriodicTicker m_obstacleAvoidTicker;
	}
}
