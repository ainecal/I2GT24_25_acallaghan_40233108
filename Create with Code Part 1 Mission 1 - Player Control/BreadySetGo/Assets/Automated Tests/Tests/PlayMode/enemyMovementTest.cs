using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class EnemyMovementPlayModeTests
{
    [UnityTest]
    public IEnumerator Enemy_Jumps_When_Grounded()
    {
        // Create ground
        var ground = new GameObject("Ground");
        var groundCollider = ground.AddComponent<BoxCollider2D>();
        ground.transform.position = Vector2.zero;

        // Create enemy
        var enemyObj = new GameObject("Enemy");
        enemyObj.transform.position = new Vector2(0, 1); // slightly above ground

        var rb = enemyObj.AddComponent<Rigidbody2D>();
        rb.gravityScale = 1f;

        var enemy = enemyObj.AddComponent<EnemyMovement>();
        enemy.jumpForce = 5f;
        enemy.jumpInterval = 0.5f; // faster for testing

        // Wait a few frames so physics can settle and Start() runs
        yield return new WaitForSeconds(0.2f);

        // Enemy should now be grounded
        Assert.IsTrue(enemyObj.transform.position.y < 1.01f, "Enemy should be grounded before jumping");

        // Wait long enough for Jump() to be invoked
        yield return new WaitForSeconds(0.6f);

        // Check if the enemy jumped (positive Y velocity)
        Assert.Greater(rb.velocity.y, 0.1f, "Enemy should have jumped with positive upward velocity");
    }
}
