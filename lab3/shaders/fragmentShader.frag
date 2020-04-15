varying vec3 vUv;
uniform vec3 colorA;
uniform vec3 colorB;


void main() {
	if (colorA.x != colorA.y)
		gl_FragColor = vec4(mix(colorA, colorB, vUv.z), 1.0);
	else
		gl_FragColor = vec4(vUv.x, vUv.y, vUv.z, 1.0);
}
